using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NAudio.Wave;
using SDL2;
using System.Windows.Forms;

namespace MusicPlayer
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicPlayerGui());
        }
    }
}
