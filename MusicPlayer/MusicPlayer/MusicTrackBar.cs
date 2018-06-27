using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicPlayer
{
    public class MusicTrackBar
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Pointer
        {
            get
            {
                return pointer;
            }
            set
            {
                pointer = Math.Min(Math.Max(0, value), BarLength);
            }
        }
        private int pointer;

        private const int TrackBarSize = 10;
        private const int PointerSize = 14;

        private Pen TrackBarPen => Pens.Gray;
        private Brush TrackBarBrush => Brushes.Gray;
        private Brush PointerBrush => Brushes.DarkGray;
        private int BarLength => Width - TrackBarSize - 1;
        private bool clicked = false;

        public MusicTrackBar(int width, int height)
        {
            Width = width;
            Height = height;
            Pointer = 0;
        }

        public void MouseMove(int mouseX, int mouseY, PlayManager playManager)
        {
            if (clicked && (playManager.PlaybackState == PlaybackState.Playing || playManager.PlaybackState == PlaybackState.Paused))
            {
                Pointer = mouseX - PointerSize / 2;
                try
                {
                    // Bug resolve - If you moved the pointer too far, then move to the next song
                    playManager.TrackSeekPosition((double)Pointer / BarLength);
                }
                catch(Exception)
                {
                    playManager.CheckTrackEnd();
                }
            }
        }

        public void MouseDown(int mouseX, int mouseY, PlayManager playManager)
        {
            clicked = MouseInTrackBar(mouseX, mouseY);
            MouseMove(mouseX, mouseY, playManager);
        }

        public void MouseUp(int mouseX, int mouseY, PlayManager playManager) => clicked = false;

        public void Draw(Graphics g)
        {
            g.Clear(SystemColors.Control);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawBar(g);
            DrawFilledBarToPointer(g);
            DrawPointer(g);
        }
        
        public void SetPointerAccordingToTrackPosition(double currentPositionSeconds, double durationSeconds)
        {
            Pointer = (int) (BarLength * (currentPositionSeconds / durationSeconds));
        }

        private bool MouseInTrackBar(int mouseX, int mouseY)
        {
            return new Rectangle(0, Height / 2 - TrackBarSize / 2, Width, TrackBarSize).Contains(mouseX, mouseY);
        }

        private bool MouseOnPointer(int mouseX, int mouseY)
        {
            return new Rectangle(Pointer - PointerSize / 2, Height / 2 - PointerSize / 2, PointerSize, PointerSize).Contains(mouseX, mouseY);
        }

        private void DrawBar(Graphics g)
        {
            int yUp = Height / 2 - TrackBarSize / 2;
            int yDown = Height / 2 + TrackBarSize / 2;
            g.DrawArc(TrackBarPen, 0, yUp, TrackBarSize, TrackBarSize, 90.0f, 180.0f);
            g.DrawArc(TrackBarPen, BarLength, yUp, TrackBarSize, TrackBarSize, 270.0f, 180.0f);
            g.DrawLine(TrackBarPen, TrackBarSize / 2, yUp, Width - TrackBarSize / 2, yUp);
            g.DrawLine(TrackBarPen, TrackBarSize / 2, yDown, Width - TrackBarSize / 2, yDown);
        }

        private void DrawFilledBarToPointer(Graphics g)
        {
            var yUp = Height / 2 - TrackBarSize / 2;
            g.FillEllipse(TrackBarBrush, 0, yUp, TrackBarSize, TrackBarSize);
            g.FillRectangle(TrackBarBrush, TrackBarSize / 2, yUp, Pointer, TrackBarSize);
        }

        private void DrawPointer(Graphics g)
        {
            g.FillEllipse(PointerBrush, Pointer, Height / 2 - PointerSize / 2, PointerSize, PointerSize);
        }
    }
}
