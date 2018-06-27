using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlayer
{
    public static class FileSystemHelper
    {
        public static List<string> GetMusicFilesFromDirectory(string directory)
        {
            return Directory.GetFileSystemEntries(directory, "*.*", SearchOption.AllDirectories)
                .Where((path) => IsAudioFile(path))
                .ToList();
        }

        public static bool IsAudioFile(string filename)
        {
            var lower = filename.ToLowerInvariant();
            return lower.EndsWith(".mp3") ||
                lower.EndsWith(".aac") ||
                lower.EndsWith(".wma") ||
                lower.EndsWith("wav");
        }
    }
}
