using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio.Wave;

namespace MusicPlayer
{
    public enum PlaybackState
    {
        Inactive,
        Playing,
        Paused,
        StoppedManually,
        StoppedAutomatically,
    };

    public class PlayManager : IDisposable
    {
        public const float VolumeMin = 0.0f;
        public const float VolumeMax = 1.0f;
        
        public Track ActiveTrack { get; private set; } = null;
        public SpectrumVisualizer SpectrumVisualizer { get; set; } = null;
        public TimeSpan? CurrentTrackPosition => trackReader?.CurrentTime;
        public PlaybackState PlaybackState { get; private set; } = PlaybackState.Inactive;
        public bool VolumeMuted { get; private set; } = false;

        public float Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = Math.Min(Math.Max(VolumeMin, value), VolumeMax);
                if (waveOut != null)
                {
                    waveOut.Volume = volume;
                }
            }
        }
        private float volume = VolumeMax;

        private float volumeWhenMuted = VolumeMax;
        private MediaFoundationReader trackReader = null;
        private WaveOut waveOut = null;
        private long trackReaderPosition = -1;
        
        public void Dispose()
        {
            StopTrack();
            SpectrumVisualizer?.Dispose();
        }

        public void Mute()
        {
            volumeWhenMuted = Volume;
            Volume = VolumeMin;
            VolumeMuted = true;
        }

        public void Unmute()
        {
            Volume = volumeWhenMuted;
            VolumeMuted = false;
        }

        public void PlayTrack(Track track)
        {
            if (ActiveTrack != null)
            {
                StopTrack();
            }
            ActiveTrack = track ?? throw new ArgumentNullException("Track is null");
            InitializeTrackComponents();
            waveOut.Volume = Volume;
            waveOut.Play();
            StartSpectrumVisualizer();
            PlaybackState = PlaybackState.Playing;
        }

        public void ResumeTrack()
        {
            if (PlaybackState == PlaybackState.Paused)
            {
                trackReader.Seek(trackReaderPosition, SeekOrigin.Begin);
                waveOut.Init(trackReader);
                waveOut.Play();
                trackReaderPosition = -1;
                SpectrumVisualizer?.Resume();
                PlaybackState = PlaybackState.Playing;
            }
        }

        public void PauseTrack()
        {
            if (PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause();
                trackReaderPosition = trackReader.Position;
                SpectrumVisualizer?.Pause();
                PlaybackState = PlaybackState.Paused;
            }
        }

        public void RewindTrack()
        {
            if (ActiveTrack != null)
            {
                PlayTrack(ActiveTrack);
            }
        }
        
        public void StopTrack()
        {
            if (ActiveTrack != null)
            {
                SpectrumVisualizer?.Stop();
                waveOut.Dispose();
                waveOut = null;
                trackReader.Dispose();
                trackReader = null;
                ActiveTrack = null;
                PlaybackState = PlaybackState.StoppedManually;
            }
        }

        /// <summary>
        /// Reset track's reader position to new relative position.
        /// </summary>
        /// <param name="relativeOffset">Number between 0 and 1</param>
        public void TrackSeekPosition(double relativeOffset)
        {
            if (trackReader != null)
            {
                var resume = PlaybackState == PlaybackState.Playing;
                PauseTrack();
                var maxSamples = waveOut.OutputWaveFormat.SampleRate * ActiveTrack.Duration.TotalSeconds;
                trackReaderPosition = (long)(maxSamples * relativeOffset) * 4;
                if (resume)
                {
                    ResumeTrack();
                }
            }
        }

        public void CheckTrackEnd()
        {
            if (trackReader != null)
            {
                var total = (int)trackReader.TotalTime.TotalSeconds;
                var current = (int)CurrentTrackPosition.Value.TotalSeconds;
                if (total <= current)
                {
                    StopTrack();
                    PlaybackState = PlaybackState.StoppedAutomatically;
                }
            }
        }
        
        public void ClearPlaybackState()
        {
            if (ActiveTrack == null)
            {
                PlaybackState = PlaybackState.Inactive;
            }
        }

        private void InitializeTrackComponents()
        {
            trackReader = new MediaFoundationReader(ActiveTrack.Path);
            waveOut = new WaveOut();
            waveOut.Init(trackReader);
        }

        private void StartSpectrumVisualizer()
        {
            if (SpectrumVisualizer != null)
            {
                SpectrumVisualizer.SetTrack(ActiveTrack.Path, waveOut.OutputWaveFormat.SampleRate, trackReader);
                SpectrumVisualizer.Start();
            }
        }
    }
}
