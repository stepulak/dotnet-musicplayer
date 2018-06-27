using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class PlaylistManager
    {
        public List<Playlist> Playlists { get; set; } = new List<Playlist>();

        public void AddPlaylist(Playlist playlist) => Playlists.Add(playlist);
        public void RemovePlaylist(Playlist playlist) => Playlists.Remove(playlist);

        public List<string> GetUnsavedPlaylists()
        {
            return Playlists
                .Where(p => !p.Saved)
                .Select(p => $"{p.Name}: {(p.Path.Length > 0 ? "Path not set" : p.Path)}")
                .ToList();
        }
        
        public void SaveAllPlaylistsWithPath()
        {
            foreach (var playlist in Playlists)
            {
                if (playlist.Path.Length > 0)
                {
                    playlist.Save();
                }
            }
        }

        public void ClearAllPlaylists()
        {
            foreach(var playlist in Playlists)
            {
                playlist.RemoveAllTracks();
            }
        }
    }
}
