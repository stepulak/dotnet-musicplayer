using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MusicPlayer
{
    public class VolumeBox
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public float Volume => points[1].X / (float)Width;

        private Point[] points = new Point[3];

        public VolumeBox(int width, int height)
        {
            Width = width;
            Height = height;
            points[0] = new Point(0, Height);
            points[1] = new Point(Width, 0);
            points[2] = new Point(Width, Height);
        }

        public void SetVolumeByClick(int mouseX, PlayManager playManager)
        {
            points[1].X = points[2].X = Math.Min(mouseX, Width);
            points[1].Y = Height - (int) (Math.Tan(Math.Atan2(Height, Width)) * points[1].X);
            playManager.Volume = Volume;
        }

        public void SetVolumeByValue(float volume, PlayManager playManager)
        {
            SetVolumeByClick((int) (volume * Width), playManager);
        }

        public void Draw(Graphics g)
        {
            g.Clear(SystemColors.Control);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillPolygon(Brushes.RoyalBlue, points);
        }
    }
}
