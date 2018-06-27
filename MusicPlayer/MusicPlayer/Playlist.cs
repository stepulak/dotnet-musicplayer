using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class Playlist
    {
        public string Path { get; set; } = String.Empty;
        public string Name => System.IO.Path.GetFileNameWithoutExtension(Path);
        public bool Saved { get; private set; } = true;
        public ListBox ListBox { get; private set; } = new ListBox { Dock = DockStyle.Fill };
        public Track ActiveTrack => tracks.ElementAtOrDefault(ListBox.SelectedIndex);
        public ReadOnlyCollection<Track> Tracks => new ReadOnlyCollection<Track>(tracks);

        private List<Track> tracks = new List<Track>();

        public Playlist()
        {
        }

        public Playlist(string path)
        {
            OpenFile(path);
        }

        public void AddTrack(Track track)
        {
            if (tracks.Find((t) => t.Path.Equals(track.Path)) != null)
            {
                throw new ArgumentException("Track already exists in playlist.");
            }
            else
            {
                tracks.Add(track);
                AddTrackToListBox(tracks.Count, track);
                if (tracks.Count == 1)
                {
                    ListBox.SelectedIndex = 0;
                }
                Saved = false;
            }
        }
        
        public void RemoveTrack(Track track)
        {
            var index = tracks.FindIndex((t) => t.Path.Equals(track.Path));
            if (index != -1)
            {
                if (index <= ListBox.SelectedIndex)
                {
                    ListBox.SelectedIndex--;
                }
                tracks.Remove(track);
                ListBox.Items.RemoveAt(index);
                Saved = false;
            }
        }

        public void RemoveAllTracks()
        {
            tracks.Clear();
            ListBox.Items.Clear();
            Saved = false;
        }
        
        public Track GetTrack(int index)
        {
            if (index < 0 || index >= tracks.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range.");
            }
            return tracks[index];
        }

        public Track MoveToTrack(TrackPlayOrder order, bool forward = true)
        {
            switch(order)
            {
                case TrackPlayOrder.Sequential:
                    return forward ? MoveToNextTrack() : MoveToPreviousTrack();
                case TrackPlayOrder.Random:
                    return MoveToRandomTrack();
                case TrackPlayOrder.Repeat:
                    return ActiveTrack;
            }
            return null;
        }

        public Track MoveToTrack(int index)
        {
            var track = GetTrack(index);
            ListBox.SelectedIndex = index;
            return track;
        }

        public Track MoveToNextTrack()
        {
            if (ListBox.SelectedIndex + 1 >= tracks.Count)
            {
                return null;
            }
            return tracks[++ListBox.SelectedIndex];
        }

        public Track MoveToPreviousTrack()
        {
            if (ListBox.SelectedIndex - 1 < 0)
            {
                return null;
            }
            return tracks[--ListBox.SelectedIndex];
        }

        public Track MoveToRandomTrack()
        {
            if (tracks.Count == 0)
            {
                return null;
            }
            ListBox.SelectedIndex = new Random().Next(tracks.Count);
            return tracks[ListBox.SelectedIndex];
        }

        public void Shuffle()
        {
            var random = new Random();
            for(int i = tracks.Count - 1; i > 0; i--)
            {
                var index = random.Next(i);
                var tmp = tracks[index];
                tracks[index] = tracks[i];
                tracks[i] = tmp;
            }
            Saved = false;
            UpdateListBoxGUI();
        }

        public void Save() => SaveTo(Path);

        public void SaveTo(string newPath)
        {
            Path = newPath;
            using (var sw = new StreamWriter(newPath))
            {
                foreach(var track in tracks)
                {
                    sw.WriteLine(track.Path);
                }
            }
        }

        public void OpenFile(string path)
        {
            Path = path;
            using (var sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    AddTrack(new Track(sr.ReadLine()));
                }
            }
        }

        public void UpdateListBoxGUI()
        {
            ListBox.Items.Clear();
            for(int i = 0; i < tracks.Count; i++)
            {
                AddTrackToListBox(i + 1, tracks[i]);
            }
            ListBox.SelectedIndex = tracks.Count > 0 ? 0 : -1;
        }

        private void AddTrackToListBox(int index, Track track)
        {
            ListBox.Items.Add($"{index}. {track.ToListBoxItem()}");
        }
    }
}
