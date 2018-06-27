using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerGui : Form
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

        #region FieldsAndProperties
        private const float VolumeChange = 0.05f;

        private PlaylistManager playlistManager = new PlaylistManager();
        private PlayManager playManager = new PlayManager();
        private Playlist activePlaylist = null;
        private int overallPlaylistCounter = 1;
        private VolumeBox volumeBox;
        private bool volumeBoxClicked = false;
        private MusicTrackBar musicTrackBar;
        private TrackPlayOrder trackPlayOrder = TrackPlayOrder.Sequential;
        #endregion

        public MusicPlayerGui()
        {
            InitializeComponent();
            volumeBox = new VolumeBox(VolumePictureBox.Width, VolumePictureBox.Height);
            musicTrackBar = new MusicTrackBar(TrackBarPictureBox.Width, TrackBarPictureBox.Height);
            playManager.SpectrumVisualizer = new SpectrumVisualizer(SpectrumVisualizerPictureBox, Handle);
            AddEmptyPlaylist();
        }

        ~MusicPlayerGui()
        {
            // Better to dispose it anyway
            playManager.Dispose();
        }

        #region Methods
        private TabPage CreateEmptyPlaylistTab(string playlistName, ListBox listBox)
        {
            var tab = new TabPage(playlistName);
            tab.Controls.Add(listBox);
            PlaylistControl.TabPages.Add(tab);
            return tab;
        }

        private void AddEmptyPlaylist()
        {
            var name = $"Playlist {overallPlaylistCounter}";
            var playlist = new Playlist();
            playlistManager.AddPlaylist(playlist);
            CreateEmptyPlaylistTab(name, playlist.ListBox);
            overallPlaylistCounter++;
        }

        private Playlist SelectedPlaylist => playlistManager.Playlists[PlaylistControl.SelectedIndex];
        private ListBox SelectedListBox => SelectedPlaylist.ListBox;
        
        private void LockPlaylistControl() => PlaylistControl.Enabled = false;
        private void UnlockPlaylistControl() => PlaylistControl.Enabled = true;
        
        private void AddTracksToSelectedPlaylist(IEnumerable<string> paths)
        {
            LockPlaylistControl();
            var builder = new StringBuilder();
            foreach (var path in paths)
            {
                try
                {
                    SelectedPlaylist.AddTrack(new Track(path));
                }
                catch (Exception ex)
                {
                    builder.Append($"Track path: {path}. Reason: {ex.Message}\n");
                }
            }
            var errorMessage = builder.ToString();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Unable to add tracks:\n{errorMessage}");
            }
            UnlockPlaylistControl();
        }

        private void OpenTracks(bool multiple)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = multiple,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddTracksToSelectedPlaylist(dialog.FileNames.ToList());
            }
        }

        private bool IsSelectedTrackPlaying()
        {
            if (SelectedPlaylist == activePlaylist && playManager.ActiveTrack != null)
            {
                return activePlaylist.ActiveTrack == playManager.ActiveTrack;
            }
            return false;
        }

        private void OpenPlaylistDialog(bool multiple)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = multiple,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                OpenPlaylists(dialog.FileNames);
            }
        }

        private void OpenPlaylists(string[] filenames)
        {
            LockPlaylistControl();
            var builder = new StringBuilder();
            foreach (var filename in filenames)
            {
                try
                {
                    var playlist = new Playlist(filename);
                    CreateEmptyPlaylistTab(playlist.Name, playlist.ListBox);
                    playlistManager.AddPlaylist(playlist);
                }
                catch (Exception ex)
                {
                    builder.Append($"Plalist {filename}: {ex.Message}\n");
                }
            }
            var errorMessage = builder.ToString();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Unable to add these playlists:\n{errorMessage}");
            }
            UnlockPlaylistControl();
        }

        private void UpdateVolumeGUI()
        {
            VolumePictureBox.Refresh();
            VolumeLabel.Text = $"{(int)(100 * playManager.Volume)} %";
        }

        private void ResetActivePlaylist()
        {
            activePlaylist = SelectedPlaylist;
        }

        private void UpdatePlayManager()
        {
            playManager.CheckTrackEnd();
            if (playManager.PlaybackState == PlaybackState.StoppedAutomatically)
            {
                // Next track
                var track = activePlaylist.MoveToTrack(trackPlayOrder);
                if (track != null)
                {
                    playManager.PlayTrack(track);
                }
                else
                {
                    activePlaylist.MoveToTrack(0);
                    playManager.ClearPlaybackState();
                }
            }
        }

        private void UpdateMusicTrackBar()
        {
            if (playManager.PlaybackState == PlaybackState.Playing)
            {
                var currentPosition = playManager.CurrentTrackPosition.Value.TotalSeconds;
                var overallDuration = playManager.ActiveTrack.Duration.TotalSeconds;
                musicTrackBar.SetPointerAccordingToTrackPosition(currentPosition, overallDuration);
                CurrentPositionLabel.Text = $"{(int)currentPosition/60}m{(int)currentPosition%60}s/{(int)overallDuration/60}m{(int)overallDuration%60}s";
            }
            else if (playManager.PlaybackState != PlaybackState.Paused)
            {
                musicTrackBar.Pointer = 0;
                CurrentPositionLabel.Text = "0m0s/0m0s";
            }
            TrackBarPictureBox.Refresh();
        }

        private void UpdateSpectrumVisualizer()
        {
            playManager.SpectrumVisualizer?.UpdateVisualizer(0.033);
            playManager.SpectrumVisualizer?.DrawVisualizer();
        }
    
        private void UncheckAllTrackOrderMenuItems()
        {
            SequentialPlayOrderMenuItem.Checked = false;
            RandomPlayOrderMenuItem.Checked = false;
            RepeatOrderMenuItem.Checked = false;
        }
        #endregion

        #region EventHandlers
        private void OpenFileMenuItem_Click(object sender, EventArgs e) => OpenTracks(false);
        private void OpenFilesMenuItem_Click(object sender, EventArgs e) => OpenTracks(true);

        private void OpenFolderMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddTracksToSelectedPlaylist(FileSystemHelper.GetMusicFilesFromDirectory(dialog.SelectedPath));
            }
        }

        private void OpenPlaylistMenuItem_Click(object sender, EventArgs e) => OpenPlaylistDialog(false);
        private void OpenMultiplePlaylistMenuItem_Click(object sender, EventArgs e) => OpenPlaylistDialog(true);

        private void NewPlaylistMenuItem_Click(object sender, EventArgs e)
        {
            AddEmptyPlaylist();
            PlaylistControl.SelectedIndex = PlaylistControl.TabCount - 1;
        }

        private void SavePlaylistMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPlaylist.Path == String.Empty)
            {
                SaveAsPlaylistMenuItem_Click(sender, e);
            }
            else
            {
                SelectedPlaylist.Save();
            }
        }

        private void SaveAsPlaylistMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                DefaultExt = ".m3u",
                AddExtension = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedPlaylist.SaveTo(dialog.FileName);
                PlaylistControl.SelectedTab.Text = SelectedPlaylist.Name;
                PlaylistControl.Refresh();
            }
        }

        private void RemovePlaylistMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPlaylist == activePlaylist)
            {
                playManager.StopTrack(); // in case of playing
            }
            var index = PlaylistControl.SelectedIndex;
            PlaylistControl.TabPages.RemoveAt(index);
            playlistManager.Playlists.RemoveAt(index);
            PlaylistControl.SelectedIndex = Math.Max(index - 1, 0);
            if (playlistManager.Playlists.Count == 0)
            {
                AddEmptyPlaylist();
            }
        }

        private void RemoveAllPlaylistMenuItem_Click(object sender, EventArgs e)
        {
            playManager.StopTrack();
            PlaylistControl.TabPages.Clear();
            playlistManager.Playlists.Clear();
            AddEmptyPlaylist();
        }

        private void ShufflePlaylistMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPlaylist == activePlaylist)
            {
                playManager.StopTrack(); // in case of playing
            }
            SelectedPlaylist.Shuffle();
        }

        private void RemoveTrackMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSelectedTrackPlaying())
            {
                playManager.StopTrack();
            }
            SelectedPlaylist.RemoveTrack(SelectedPlaylist.ActiveTrack);
        }

        private void RemoveAllTracksMenuItem_Click(object sender, EventArgs e)
        {
            if (IsSelectedTrackPlaying())
            {
                playManager.StopTrack();
            }
            SelectedPlaylist.RemoveAllTracks();
        }

        private void PlayMenuItem_Click(object sender, EventArgs e)
        {
            activePlaylist = SelectedPlaylist;

            if (activePlaylist.ActiveTrack == null)
            {
                MessageBox.Show("Please select track to play");
                return;
            }
            if (playManager.PlaybackState == PlaybackState.Paused)
            {
                playManager.ResumeTrack();
            }
            else
            {
                playManager.PlayTrack(activePlaylist.ActiveTrack);
            }
        }

        private void PauseMenuItem_Click(object sender, EventArgs e) => playManager.PauseTrack();
        private void StopMenuItem_Click(object sender, EventArgs e) => playManager.StopTrack();
        private void RewindMenuItem_Click(object sender, EventArgs e) => playManager.RewindTrack();

        private void NextMenuItem_Click(object sender, EventArgs e)
        {
            playManager.StopTrack();
            activePlaylist.MoveToTrack(trackPlayOrder);
            PlayMenuItem_Click(sender, e);
        }

        private void PreviousMenuItem_Click(object sender, EventArgs e)
        {
            playManager.StopTrack();
            activePlaylist.MoveToTrack(trackPlayOrder, false);
            PlayMenuItem_Click(sender, e);
        }

        private void MuteVolumeMenuItem_Click(object sender, EventArgs e)
        {
            if (!playManager.VolumeMuted)
            {
                playManager.Mute();
                MuteVolumeMenuItem.Text = "Unmute";
            }
            else
            {
                playManager.Unmute();
                MuteVolumeMenuItem.Text = "Mute";
            }
            volumeBox.SetVolumeByValue(playManager.Volume, playManager);
            UpdateVolumeGUI();
        }

        private void IncreaseVolumeMenuItem_Click(object sender, EventArgs e)
        {
            volumeBox.SetVolumeByValue(playManager.Volume + VolumeChange, playManager);
            UpdateVolumeGUI();
        }

        private void DecreaseVolumeMenuItem_Click(object sender, EventArgs e)
        {
            volumeBox.SetVolumeByValue(playManager.Volume - VolumeChange, playManager);
            UpdateVolumeGUI();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) =>  Application.Exit();
        private void AboutMenuItem_Click(object sender, EventArgs e) => new AboutBox().Show();
        private void VolumePictureBox_Paint(object sender, PaintEventArgs e) => volumeBox.Draw(e.Graphics);

        private void VolumePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            volumeBoxClicked = true;
            VolumePictureBox_MouseMove(sender, e);
        }

        private void VolumePictureBox_MouseUp(object sender, MouseEventArgs e) => volumeBoxClicked = false;

        private void VolumePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (volumeBoxClicked)
            {
                volumeBox.SetVolumeByClick(Math.Max(0, e.X), playManager);
                UpdateVolumeGUI();
            }
        }

        private void TrackBarPictureBox_Paint(object sender, PaintEventArgs e) => musicTrackBar.Draw(e.Graphics);
        
        private void TrackBarPictureBox_Resize(object sender, EventArgs e)
        {
            musicTrackBar.Width = TrackBarPictureBox.Width;
            musicTrackBar.Height = TrackBarPictureBox.Height;
            TrackBarPictureBox.Refresh();
        }

        private void TrackBarPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            musicTrackBar.MouseMove(e.X, e.Y, playManager);
            TrackBarPictureBox.Refresh();
        }

        private void TrackBarPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            musicTrackBar.MouseDown(e.X, e.Y, playManager);
            TrackBarPictureBox.Refresh();
        }

        private void TrackBarPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            musicTrackBar.MouseUp(e.X, e.Y, playManager);
            TrackBarPictureBox.Refresh();
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            UpdateMusicTrackBar();
            UpdatePlayManager();
            UpdateSpectrumVisualizer();
        }

        private void SequentialPlayOrderMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllTrackOrderMenuItems();
            SequentialPlayOrderMenuItem.Checked = true;
            trackPlayOrder = TrackPlayOrder.Sequential;
        }

        private void RandomPlayOrderMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllTrackOrderMenuItems();
            RandomPlayOrderMenuItem.Checked = true;
            trackPlayOrder = TrackPlayOrder.Random;
        }

        private void RepeatOrderMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAllTrackOrderMenuItems();
            RepeatOrderMenuItem.Checked = true;
            trackPlayOrder = TrackPlayOrder.Repeat;
        }

        private void SpectrumVisualizerPictureBox_Paint(object sender, PaintEventArgs e) => playManager.SpectrumVisualizer?.DrawVisualizer();

        private void EditTrackTagsMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedPlaylist.ActiveTrack == null)
            {
                MessageBox.Show("Please select track to edit.");
                return;
            }
            var dialog = new TrackTagEditor { Track = SelectedPlaylist.ActiveTrack };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SelectedPlaylist.UpdateListBoxGUI();
            }
        }

        private void PlaylistsTreeViewerMenuItem_Click(object sender, EventArgs e) => new PlaylistsTreeViewer(PlaylistControl).ShowDialog();
        #endregion
    }
}
