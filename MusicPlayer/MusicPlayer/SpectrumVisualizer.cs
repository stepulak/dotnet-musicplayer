using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDL2;
using NAudio.Wave;

namespace MusicPlayer
{
    public class SpectrumVisualizer : IDisposable
    {
        #region WinAPI Entry Points
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SetWindowPos(
            IntPtr handle,
            IntPtr handleAfter,
            int x,
            int y,
            int cx,
            int cy,
            uint flags
        );

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr child, IntPtr newParent);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr handle, int command);
        #endregion

        public int SampleRate { get; private set; } = 0;
        public int SamplesPerUpdate => (int)(MusicTimeRate * SampleRate);

        private enum TrackStatus
        {
            On,
            Off,
            Paused,
        };

        private int TrackReaderPositionShift => SampleRate;
        private const double MusicTimeRate = 1.0 / 15.0;
        private const double SpectrumColumnUpdateSpeed = 100.0;
        private const int SpectrumColumnHeightRatio = 5;
        private const int NumberOfSpectrumColumns = 16;

        private TrackStatus trackStatus = TrackStatus.Off;
        private double timer;
        private int width, height;

        // SDL2
        private IntPtr window;
        private IntPtr renderer;

        // Spectrum columns
        private double[] desiredColumns = new double[NumberOfSpectrumColumns];
        private double[] currentColumns = new double[NumberOfSpectrumColumns];

        // Sample buffers
        private double[] samplesReal, samplesImaginary;

        // Readers
        private MediaFoundationReader synchronizationReader = null;
        private MediaFoundationReader trackReader = null;
        
        public SpectrumVisualizer(PictureBox pictureBox, IntPtr ControlHandle)
        {
            width = pictureBox.Size.Width;
            height = pictureBox.Size.Height;
            InitSDL(pictureBox.Handle, ControlHandle);
            ClearSpectrumColumns();
        }

        public void Dispose()
        {
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();
        }

        public void SetTrack(string trackPath, int sampleRate, MediaFoundationReader syncReader)
        {
            SampleRate = sampleRate;
            synchronizationReader = syncReader;
            // Size of sample buffers must be power of two.
            var arraySize = (int) Math.Pow(2, ((int)Math.Log(SamplesPerUpdate, 2)) + 1);
            samplesReal = new double[arraySize];
            samplesImaginary = new double[arraySize];
            trackReader = new MediaFoundationReader(trackPath);
            timer = 0.0;
        }

        public void Start()
        {
            trackStatus = TrackStatus.On;
            SynchronizeReaderPositions();
        }

        public void Stop()
        {
            trackStatus = TrackStatus.Off;
            SampleRate = 0;
            synchronizationReader = null; // do not dispose
            trackReader.Dispose();
            trackReader = null;
            samplesReal = samplesImaginary = null;
            ClearSpectrumColumns();
        }

        public void Pause()
        {
            trackStatus = TrackStatus.Paused;
            SynchronizeReaderPositions();
        }

        public void Resume()
        {
            trackStatus = TrackStatus.On;
            SynchronizeReaderPositions();
        }

        private void InitSDL(IntPtr pictureBoxControlHandle, IntPtr formControlHandle)
        {
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
            window = SDL.SDL_CreateWindow(String.Empty, SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                width, height, SDL.SDL_WindowFlags.SDL_WINDOW_BORDERLESS);
            SDL.SDL_SysWMinfo info = new SDL.SDL_SysWMinfo();
            SDL.SDL_GetWindowWMInfo(window, ref info);
            IntPtr winHandle = info.info.win.window;
            SetWindowPos(winHandle, formControlHandle, 0, 0, 0, 0, 0x0401);
            SetParent(winHandle, pictureBoxControlHandle);
            ShowWindow(winHandle, 1);
            renderer = SDL.SDL_CreateRenderer(window, 0, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
        }

        private void ClearSpectrumColumns()
        {
            Array.Clear(desiredColumns, 0, desiredColumns.Length);
            Array.Clear(currentColumns, 0, currentColumns.Length);
        }

        private void ReadNewSamples()
        {
            while (timer >= MusicTimeRate)
            {
                FillSampleBuffers();
                timer -= MusicTimeRate;
            }
            // In case of lags
            if (trackReader.Position < synchronizationReader.Position - TrackReaderPositionShift)
            {
                FillSampleBuffers();
            }
        }

        private void FillSampleBuffers()
        {
            const double divider = 32768;
            var buffer = new byte[4];
            for (int i = 0; i < SamplesPerUpdate / 2; i++)
            {
                var read = trackReader.Read(buffer, 0, 4);
                if (read == 4)
                {
                    samplesReal[i] = BitConverter.ToInt16(buffer, 0) / divider;
                    samplesImaginary[i] = BitConverter.ToInt16(buffer, 2) / divider;
                }
                else
                {
                    samplesReal[i] = samplesImaginary[i] = 0.0;
                }
            }
        }

        private void CountSpectrum()
        {
            int samplesPerColumn = SamplesPerUpdate / NumberOfSpectrumColumns;
            for (int i = 0; i < NumberOfSpectrumColumns; i++)
            {
                double avg = 0;
                for (int j = 0; j < samplesPerColumn; j++)
                {
                    int index = j + i * samplesPerColumn;
                    avg += Math.Sqrt(samplesReal[index] * samplesReal[index] + samplesImaginary[index] * samplesImaginary[index]);
                }
                desiredColumns[i] = avg / samplesPerColumn;
                desiredColumns[i] *= (i == 0) ? SpectrumColumnHeightRatio / 2 : SpectrumColumnHeightRatio;
            }
            Array.Clear(samplesReal, 0, samplesReal.Length);
            Array.Clear(samplesImaginary, 0, samplesImaginary.Length);
        }
        
        private void UpdateSpectrumColumnHeights(double deltaTime)
        {
            for (int i = 0; i < desiredColumns.Length; i++)
            {
                if (desiredColumns[i] > currentColumns[i])
                {
                    currentColumns[i] = desiredColumns[i];
                }
                else
                {
                    currentColumns[i] = Math.Max(currentColumns[i] - SpectrumColumnUpdateSpeed * deltaTime, 0);
                }
            }
        }

        public void UpdateVisualizer(double deltaTime)
        {
            if (trackStatus == TrackStatus.On)
            {
                timer += deltaTime;
                ReadNewSamples();
                FFT(samplesReal, samplesImaginary);
                CountSpectrum();
                UpdateSpectrumColumnHeights(deltaTime);
            }
        }
        
        public void DrawVisualizer()
        {
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_SetRenderDrawColor(renderer, 65, 105, 225, 255); // Royal blue

            var columnSpace = 2;
            var columnWidth = (width - columnSpace * currentColumns.Length) / currentColumns.Length;
            var rect = new SDL.SDL_Rect { w = columnWidth };
            
            // mirror reflected columns
            for (int i = 0; i < currentColumns.Length/2; i++)
            {
                rect.h = (int)currentColumns[i];
                rect.y = height - rect.h;
                rect.x = width / 2 - (i + 1) * columnWidth - i * columnSpace - columnSpace / 2;
                SDL.SDL_RenderFillRect(renderer, ref rect);
                rect.x = width / 2 + i * columnWidth + i * columnSpace + columnSpace / 2;
                SDL.SDL_RenderFillRect(renderer, ref rect);
            }
            SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
            SDL.SDL_RenderPresent(renderer);
        }

        public void SynchronizeReaderPositions()
        {
            trackReader.Seek(synchronizationReader.Position - TrackReaderPositionShift, System.IO.SeekOrigin.Begin);
        }

        private static bool IsDoubleInteger(double value)
        {
            return Math.Abs(value % 1) <= Double.Epsilon * 100;
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        /// <summary>
        /// Binary reverse every value in two arrays simultaneously.
        /// </summary>
        /// <param name="x">Array 1</param>
        /// <param name="y">Array 2</param>
        private static void BinaryReverseTwoArrays(double[] x, double[] y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("x.Length != y.Lenght");
            }
            int j = 0, n1, n2 = x.Length / 2;
            for (int i = 1; i <= x.Length - 2; i++)
            {
                n1 = n2;
                while (j >= n1)
                {
                    j -= n1;
                    n1 /= 2;
                }
                j += n1;
                if (i < j)
                {
                    Swap(ref x[i], ref x[j]);
                    Swap(ref y[i], ref y[j]);
                }
            }
        }

        private static void FFT_Radix2InPlace(double[] real, double[] imaginary, int exponent)
        {
            int m = 1;
            for (int i = 0; i < exponent; i++)
            {
                double a = 0.0;
                int n = m;
                m *= 2;

                for (int j = 0; j < n; j++)
                {
                    var c = Math.Cos(a);
                    var s = Math.Sin(a);
                    a += -2 * Math.PI / m;
                    for (int k = j; k < real.Length; k = k + m)
                    {
                        var t1 = c * real[k + n] - s * imaginary[k + n];
                        var t2 = s * real[k + n] + c * imaginary[k + n];
                        real[k + n] = real[k] - t1;
                        imaginary[k + n] = imaginary[k] - t2;
                        real[k] += t1;
                        imaginary[k] += t2;
                    }
                }
            }
        }

        /// <summary>
        /// In place Radix2 FFT based on https://cnx.org/exports/ce67266a-1851-47e4-8bfc-82eb447212b4%407.pdf/decimation-in-time-dit-radix-2-fft-7.pdf
        /// Original author: Douglas L. Jones
        /// Creative Commons "Attribution" license 1.0 http://creativecommons.org/licenses/by/1.0/
        /// This C# implementation was made by me.
        /// </summary>
        /// <param name="real">Array of real values (even indexed samples)</param>
        /// <param name="imaginary">Array of imaginary values (odd indexed samples)</param>
        private static void FFT(double[] real, double[] imaginary)
        {
            if (real.Length != imaginary.Length)
            {
                throw new ArgumentException("real.Length != imaginary.Lenght");
            }
            var exponent = Math.Log(real.Length, 2);
            if (!IsDoubleInteger(exponent))
            {
                throw new ArgumentException("Array's length is not power of two");
            }
            BinaryReverseTwoArrays(real, imaginary);
            FFT_Radix2InPlace(real, imaginary, (int)exponent);
        }
    }
}
