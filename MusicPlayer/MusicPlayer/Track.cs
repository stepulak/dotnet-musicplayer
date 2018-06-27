using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicPlayer
{
    public class Track
    {
        private TagLib.Tag tags;

        public string Path { get; }
        public string Author => tags.AlbumArtists.FirstOrDefault() ?? String.Empty;
        public string Title => tags.Title;
        public string Album => tags.Album;
        public string Genre => tags.FirstGenre;
        public uint Year => tags.Year;
        public TimeSpan Duration { get; }
        public int Bitrate { get; }
        public int Size { get; }

        public Track(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Track {path} does not exist.");
            }
            if (!FileSystemHelper.IsAudioFile(path))
            {
                throw new ArgumentException("Path does not refer to supported audio file.");
            }
            Path = System.IO.Path.GetFullPath(path);
            using (var file = TagLib.File.Create(path))
            {
                tags = file.Tag;
                Duration = file.Properties.Duration;
                Bitrate = file.Properties.AudioBitrate;
                file.Save();
            }
        }
        
        public void UpdateTags(string author, string title, string album, string genre, uint year)
        {
            using (var file = TagLib.File.Create(Path))
            {
                tags = file.Tag;
                // Clear tags
                tags.AlbumArtists = null;
                tags.Title = null;
                tags.Album = null;
                tags.Genres = null;
                // Update them
                tags.AlbumArtists = new[] { author };
                tags.Title = title;
                tags.Album = album;
                tags.Genres = new[] { genre };
                tags.Year = year;
                file.Save();
            }
        }
        
        public string ToListBoxItem()
        {
            return $"{System.IO.Path.GetFileName(Path)} {(int)Duration.TotalMinutes}m{(int)Duration.TotalSeconds%60}s {Album}";
        }

        public override string ToString()
        {
            return $"{Author};{Title};{Album};{Genre};{Year};{Duration.ToString()};{Path}";
        }
    }
}
