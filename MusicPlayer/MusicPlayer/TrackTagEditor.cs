using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class TrackTagEditor : Form
    {
        public Track Track { get; set; }

        public TrackTagEditor()
        {
            InitializeComponent();
        }

        private void TrackTagEditor_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Track.Title;
            AlbumTextBox.Text = Track.Album;
            AuthorTextBox.Text = Track.Author;
            GenreTextBox.Text = Track.Genre;
            YearNumericUpDown.Value = Track.Year;
            FilenameLabel.Text = Path.GetFileName(Track.Path);
            FiletypeLabel.Text = Path.GetExtension(Track.Path).ToUpperInvariant();
            LenghtLabel.Text = Track.Duration.ToString();
            BitrateLabel.Text = $"{Track.Bitrate.ToString()} kbps";
            SizeLabel.Text = $"{(new FileInfo(Track.Path).Length / 1024.0 / 1024.0).ToString("#.#")} MB";
        }

        private void SaveTagsButton_Click(object sender, EventArgs e)
        {
            Track.UpdateTags(AuthorTextBox.Text, TitleTextBox.Text, AlbumTextBox.Text, GenreTextBox.Text, (uint)YearNumericUpDown.Value);
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
