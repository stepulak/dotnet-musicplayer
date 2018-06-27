namespace MusicPlayer
{
    partial class MusicPlayerGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerGui));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TrackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveTrackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllTracksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.EditTrackTagsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SavePlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.RemovePlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAllPlaylistMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ShuffleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaybackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RewindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreviousMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SequentialPlayOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomPlayOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepeatOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuteVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncreaseVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DecreaseVolumeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PlaylistControl = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.VolumeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousTrackButton = new System.Windows.Forms.Button();
            this.PlayTrackButton = new System.Windows.Forms.Button();
            this.PauseTrackButton = new System.Windows.Forms.Button();
            this.StopTrackButton = new System.Windows.Forms.Button();
            this.NextTrackButton = new System.Windows.Forms.Button();
            this.RewindTrackButton = new System.Windows.Forms.Button();
            this.MuteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VolumePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpectrumVisualizerPictureBox = new System.Windows.Forms.PictureBox();
            this.TrackBarPictureBox = new System.Windows.Forms.PictureBox();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.PlaylistsTreeViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumVisualizerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrackMenuItem,
            this.PlaylistMenuItem,
            this.PlaybackMenuItem,
            this.VolumeMenuItem,
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrackMenuItem
            // 
            this.TrackMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem,
            this.OpenFilesMenuItem,
            this.OpenFolderMenuItem,
            this.toolStripMenuItem1,
            this.RemoveTrackMenuItem,
            this.RemoveAllTracksMenuItem,
            this.toolStripMenuItem7,
            this.EditTrackTagsMenuItem});
            this.TrackMenuItem.Name = "TrackMenuItem";
            this.TrackMenuItem.Size = new System.Drawing.Size(47, 20);
            this.TrackMenuItem.Text = "Track";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(164, 22);
            this.OpenFileMenuItem.Text = "Open File...";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // OpenFilesMenuItem
            // 
            this.OpenFilesMenuItem.Name = "OpenFilesMenuItem";
            this.OpenFilesMenuItem.Size = new System.Drawing.Size(164, 22);
            this.OpenFilesMenuItem.Text = "Open Files...";
            this.OpenFilesMenuItem.Click += new System.EventHandler(this.OpenFilesMenuItem_Click);
            // 
            // OpenFolderMenuItem
            // 
            this.OpenFolderMenuItem.Name = "OpenFolderMenuItem";
            this.OpenFolderMenuItem.Size = new System.Drawing.Size(164, 22);
            this.OpenFolderMenuItem.Text = "Open Folder...";
            this.OpenFolderMenuItem.Click += new System.EventHandler(this.OpenFolderMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // RemoveTrackMenuItem
            // 
            this.RemoveTrackMenuItem.Name = "RemoveTrackMenuItem";
            this.RemoveTrackMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RemoveTrackMenuItem.Text = "Remove Selected";
            this.RemoveTrackMenuItem.Click += new System.EventHandler(this.RemoveTrackMenuItem_Click);
            // 
            // RemoveAllTracksMenuItem
            // 
            this.RemoveAllTracksMenuItem.Name = "RemoveAllTracksMenuItem";
            this.RemoveAllTracksMenuItem.Size = new System.Drawing.Size(164, 22);
            this.RemoveAllTracksMenuItem.Text = "Remove All";
            this.RemoveAllTracksMenuItem.Click += new System.EventHandler(this.RemoveAllTracksMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(161, 6);
            // 
            // EditTrackTagsMenuItem
            // 
            this.EditTrackTagsMenuItem.Name = "EditTrackTagsMenuItem";
            this.EditTrackTagsMenuItem.Size = new System.Drawing.Size(164, 22);
            this.EditTrackTagsMenuItem.Text = "Edit Track Tabs...";
            this.EditTrackTagsMenuItem.Click += new System.EventHandler(this.EditTrackTagsMenuItem_Click);
            // 
            // PlaylistMenuItem
            // 
            this.PlaylistMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPlaylistMenuItem,
            this.toolStripSeparator1,
            this.OpenPlaylistMenuItem,
            this.toolStripMenuItem8,
            this.toolStripMenuItem2,
            this.SavePlaylistMenuItem,
            this.SaveAsMenuItem,
            this.toolStripMenuItem3,
            this.RemovePlaylistMenuItem,
            this.RemoveAllPlaylistMenuItem,
            this.toolStripMenuItem4,
            this.ShuffleMenuItem,
            this.toolStripMenuItem9,
            this.PlaylistsTreeViewerMenuItem});
            this.PlaylistMenuItem.Name = "PlaylistMenuItem";
            this.PlaylistMenuItem.Size = new System.Drawing.Size(56, 20);
            this.PlaylistMenuItem.Text = "Playlist";
            // 
            // NewPlaylistMenuItem
            // 
            this.NewPlaylistMenuItem.Name = "NewPlaylistMenuItem";
            this.NewPlaylistMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NewPlaylistMenuItem.Text = "New";
            this.NewPlaylistMenuItem.Click += new System.EventHandler(this.NewPlaylistMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // OpenPlaylistMenuItem
            // 
            this.OpenPlaylistMenuItem.Name = "OpenPlaylistMenuItem";
            this.OpenPlaylistMenuItem.Size = new System.Drawing.Size(188, 22);
            this.OpenPlaylistMenuItem.Text = "Open Playlist...";
            this.OpenPlaylistMenuItem.Click += new System.EventHandler(this.OpenPlaylistMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem8.Text = "Open Playlists...";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.OpenMultiplePlaylistMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // SavePlaylistMenuItem
            // 
            this.SavePlaylistMenuItem.Name = "SavePlaylistMenuItem";
            this.SavePlaylistMenuItem.Size = new System.Drawing.Size(188, 22);
            this.SavePlaylistMenuItem.Text = "Save Selected...";
            this.SavePlaylistMenuItem.Click += new System.EventHandler(this.SavePlaylistMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(188, 22);
            this.SaveAsMenuItem.Text = "Save As Selected...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsPlaylistMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 6);
            // 
            // RemovePlaylistMenuItem
            // 
            this.RemovePlaylistMenuItem.Name = "RemovePlaylistMenuItem";
            this.RemovePlaylistMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RemovePlaylistMenuItem.Text = "Remove Selected";
            this.RemovePlaylistMenuItem.Click += new System.EventHandler(this.RemovePlaylistMenuItem_Click);
            // 
            // RemoveAllPlaylistMenuItem
            // 
            this.RemoveAllPlaylistMenuItem.Name = "RemoveAllPlaylistMenuItem";
            this.RemoveAllPlaylistMenuItem.Size = new System.Drawing.Size(188, 22);
            this.RemoveAllPlaylistMenuItem.Text = "Remove All";
            this.RemoveAllPlaylistMenuItem.Click += new System.EventHandler(this.RemoveAllPlaylistMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 6);
            // 
            // ShuffleMenuItem
            // 
            this.ShuffleMenuItem.Name = "ShuffleMenuItem";
            this.ShuffleMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ShuffleMenuItem.Text = "Shuffle";
            this.ShuffleMenuItem.Click += new System.EventHandler(this.ShufflePlaylistMenuItem_Click);
            // 
            // PlaybackMenuItem
            // 
            this.PlaybackMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayMenuItem,
            this.PauseMenuItem,
            this.StopMenuItem,
            this.RewindMenuItem,
            this.NextMenuItem,
            this.PreviousMenuItem,
            this.toolStripMenuItem5,
            this.PlayOrderMenuItem});
            this.PlaybackMenuItem.Name = "PlaybackMenuItem";
            this.PlaybackMenuItem.Size = new System.Drawing.Size(66, 20);
            this.PlaybackMenuItem.Text = "Playback";
            // 
            // PlayMenuItem
            // 
            this.PlayMenuItem.Name = "PlayMenuItem";
            this.PlayMenuItem.Size = new System.Drawing.Size(129, 22);
            this.PlayMenuItem.Text = "Play";
            this.PlayMenuItem.Click += new System.EventHandler(this.PlayMenuItem_Click);
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(129, 22);
            this.PauseMenuItem.Text = "Pause";
            this.PauseMenuItem.Click += new System.EventHandler(this.PauseMenuItem_Click);
            // 
            // StopMenuItem
            // 
            this.StopMenuItem.Name = "StopMenuItem";
            this.StopMenuItem.Size = new System.Drawing.Size(129, 22);
            this.StopMenuItem.Text = "Stop";
            this.StopMenuItem.Click += new System.EventHandler(this.StopMenuItem_Click);
            // 
            // RewindMenuItem
            // 
            this.RewindMenuItem.Name = "RewindMenuItem";
            this.RewindMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RewindMenuItem.Text = "Rewind";
            this.RewindMenuItem.Click += new System.EventHandler(this.RewindMenuItem_Click);
            // 
            // NextMenuItem
            // 
            this.NextMenuItem.Name = "NextMenuItem";
            this.NextMenuItem.Size = new System.Drawing.Size(129, 22);
            this.NextMenuItem.Text = "Next";
            this.NextMenuItem.Click += new System.EventHandler(this.NextMenuItem_Click);
            // 
            // PreviousMenuItem
            // 
            this.PreviousMenuItem.Name = "PreviousMenuItem";
            this.PreviousMenuItem.Size = new System.Drawing.Size(129, 22);
            this.PreviousMenuItem.Text = "Previous";
            this.PreviousMenuItem.Click += new System.EventHandler(this.PreviousMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(126, 6);
            // 
            // PlayOrderMenuItem
            // 
            this.PlayOrderMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SequentialPlayOrderMenuItem,
            this.RandomPlayOrderMenuItem,
            this.RepeatOrderMenuItem});
            this.PlayOrderMenuItem.Name = "PlayOrderMenuItem";
            this.PlayOrderMenuItem.Size = new System.Drawing.Size(129, 22);
            this.PlayOrderMenuItem.Text = "Play Order";
            // 
            // SequentialPlayOrderMenuItem
            // 
            this.SequentialPlayOrderMenuItem.Checked = true;
            this.SequentialPlayOrderMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SequentialPlayOrderMenuItem.Name = "SequentialPlayOrderMenuItem";
            this.SequentialPlayOrderMenuItem.Size = new System.Drawing.Size(129, 22);
            this.SequentialPlayOrderMenuItem.Text = "Sequential";
            this.SequentialPlayOrderMenuItem.Click += new System.EventHandler(this.SequentialPlayOrderMenuItem_Click);
            // 
            // RandomPlayOrderMenuItem
            // 
            this.RandomPlayOrderMenuItem.Name = "RandomPlayOrderMenuItem";
            this.RandomPlayOrderMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RandomPlayOrderMenuItem.Text = "Random";
            this.RandomPlayOrderMenuItem.Click += new System.EventHandler(this.RandomPlayOrderMenuItem_Click);
            // 
            // RepeatOrderMenuItem
            // 
            this.RepeatOrderMenuItem.Name = "RepeatOrderMenuItem";
            this.RepeatOrderMenuItem.Size = new System.Drawing.Size(129, 22);
            this.RepeatOrderMenuItem.Text = "Repeat";
            this.RepeatOrderMenuItem.Click += new System.EventHandler(this.RepeatOrderMenuItem_Click);
            // 
            // VolumeMenuItem
            // 
            this.VolumeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuteVolumeMenuItem,
            this.IncreaseVolumeMenuItem,
            this.DecreaseVolumeMenuItem});
            this.VolumeMenuItem.Name = "VolumeMenuItem";
            this.VolumeMenuItem.Size = new System.Drawing.Size(59, 20);
            this.VolumeMenuItem.Text = "Volume";
            // 
            // MuteVolumeMenuItem
            // 
            this.MuteVolumeMenuItem.Name = "MuteVolumeMenuItem";
            this.MuteVolumeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.MuteVolumeMenuItem.Text = "Mute";
            this.MuteVolumeMenuItem.Click += new System.EventHandler(this.MuteVolumeMenuItem_Click);
            // 
            // IncreaseVolumeMenuItem
            // 
            this.IncreaseVolumeMenuItem.Name = "IncreaseVolumeMenuItem";
            this.IncreaseVolumeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.IncreaseVolumeMenuItem.Text = "Increase";
            this.IncreaseVolumeMenuItem.Click += new System.EventHandler(this.IncreaseVolumeMenuItem_Click);
            // 
            // DecreaseVolumeMenuItem
            // 
            this.DecreaseVolumeMenuItem.Name = "DecreaseVolumeMenuItem";
            this.DecreaseVolumeMenuItem.Size = new System.Drawing.Size(121, 22);
            this.DecreaseVolumeMenuItem.Text = "Decrease";
            this.DecreaseVolumeMenuItem.Click += new System.EventHandler(this.DecreaseVolumeMenuItem_Click);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.toolStripMenuItem6,
            this.ExitMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutMenuItem.Text = "About...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PlaylistControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TrackBarPictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PlaylistControl
            // 
            this.PlaylistControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaylistControl.Location = new System.Drawing.Point(3, 3);
            this.PlaylistControl.Name = "PlaylistControl";
            this.PlaylistControl.SelectedIndex = 0;
            this.PlaylistControl.Size = new System.Drawing.Size(617, 170);
            this.PlaylistControl.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.VolumeLabel,
            this.toolStripStatusLabel2,
            this.CurrentPositionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Volume:";
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(38, 17);
            this.VolumeLabel.Text = "100 %";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel2.Text = "Current Position:";
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(52, 17);
            this.CurrentPositionLabel.Text = "xxxx/xxxx";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 214);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 71);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.PreviousTrackButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.PlayTrackButton, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.PauseTrackButton, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.StopTrackButton, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.NextTrackButton, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.RewindTrackButton, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.MuteButton, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 7, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(415, 57);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // PreviousTrackButton
            // 
            this.PreviousTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousTrackButton.BackgroundImage")));
            this.PreviousTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PreviousTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousTrackButton.Location = new System.Drawing.Point(3, 8);
            this.PreviousTrackButton.Name = "PreviousTrackButton";
            this.PreviousTrackButton.Size = new System.Drawing.Size(39, 41);
            this.PreviousTrackButton.TabIndex = 1;
            this.PreviousTrackButton.UseVisualStyleBackColor = true;
            this.PreviousTrackButton.Click += new System.EventHandler(this.PreviousMenuItem_Click);
            // 
            // PlayTrackButton
            // 
            this.PlayTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlayTrackButton.BackgroundImage")));
            this.PlayTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PlayTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayTrackButton.Location = new System.Drawing.Point(48, 8);
            this.PlayTrackButton.Name = "PlayTrackButton";
            this.PlayTrackButton.Size = new System.Drawing.Size(39, 41);
            this.PlayTrackButton.TabIndex = 2;
            this.PlayTrackButton.UseVisualStyleBackColor = true;
            this.PlayTrackButton.Click += new System.EventHandler(this.PlayMenuItem_Click);
            // 
            // PauseTrackButton
            // 
            this.PauseTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseTrackButton.BackgroundImage")));
            this.PauseTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PauseTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseTrackButton.Location = new System.Drawing.Point(93, 8);
            this.PauseTrackButton.Name = "PauseTrackButton";
            this.PauseTrackButton.Size = new System.Drawing.Size(39, 41);
            this.PauseTrackButton.TabIndex = 3;
            this.PauseTrackButton.UseVisualStyleBackColor = true;
            this.PauseTrackButton.Click += new System.EventHandler(this.PauseMenuItem_Click);
            // 
            // StopTrackButton
            // 
            this.StopTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopTrackButton.BackgroundImage")));
            this.StopTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopTrackButton.Location = new System.Drawing.Point(138, 8);
            this.StopTrackButton.Name = "StopTrackButton";
            this.StopTrackButton.Size = new System.Drawing.Size(39, 41);
            this.StopTrackButton.TabIndex = 4;
            this.StopTrackButton.UseVisualStyleBackColor = true;
            this.StopTrackButton.Click += new System.EventHandler(this.StopMenuItem_Click);
            // 
            // NextTrackButton
            // 
            this.NextTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextTrackButton.BackgroundImage")));
            this.NextTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NextTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextTrackButton.Location = new System.Drawing.Point(183, 8);
            this.NextTrackButton.Name = "NextTrackButton";
            this.NextTrackButton.Size = new System.Drawing.Size(39, 41);
            this.NextTrackButton.TabIndex = 5;
            this.NextTrackButton.UseVisualStyleBackColor = true;
            this.NextTrackButton.Click += new System.EventHandler(this.NextMenuItem_Click);
            // 
            // RewindTrackButton
            // 
            this.RewindTrackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RewindTrackButton.BackgroundImage")));
            this.RewindTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RewindTrackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RewindTrackButton.Location = new System.Drawing.Point(228, 8);
            this.RewindTrackButton.Name = "RewindTrackButton";
            this.RewindTrackButton.Size = new System.Drawing.Size(39, 41);
            this.RewindTrackButton.TabIndex = 6;
            this.RewindTrackButton.UseVisualStyleBackColor = true;
            this.RewindTrackButton.Click += new System.EventHandler(this.RewindMenuItem_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteButton.BackgroundImage")));
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MuteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MuteButton.Location = new System.Drawing.Point(273, 8);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(39, 41);
            this.MuteButton.TabIndex = 7;
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteVolumeMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VolumePictureBox);
            this.groupBox2.Location = new System.Drawing.Point(318, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(94, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // VolumePictureBox
            // 
            this.VolumePictureBox.Location = new System.Drawing.Point(6, 19);
            this.VolumePictureBox.Name = "VolumePictureBox";
            this.VolumePictureBox.Size = new System.Drawing.Size(82, 16);
            this.VolumePictureBox.TabIndex = 8;
            this.VolumePictureBox.TabStop = false;
            this.VolumePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.VolumePictureBox_Paint);
            this.VolumePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VolumePictureBox_MouseDown);
            this.VolumePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VolumePictureBox_MouseMove);
            this.VolumePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VolumePictureBox_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpectrumVisualizerPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(424, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spectrum Visualizer";
            // 
            // SpectrumVisualizerPictureBox
            // 
            this.SpectrumVisualizerPictureBox.Location = new System.Drawing.Point(6, 15);
            this.SpectrumVisualizerPictureBox.Name = "SpectrumVisualizerPictureBox";
            this.SpectrumVisualizerPictureBox.Size = new System.Drawing.Size(178, 44);
            this.SpectrumVisualizerPictureBox.TabIndex = 0;
            this.SpectrumVisualizerPictureBox.TabStop = false;
            this.SpectrumVisualizerPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SpectrumVisualizerPictureBox_Paint);
            // 
            // TrackBarPictureBox
            // 
            this.TrackBarPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBarPictureBox.Location = new System.Drawing.Point(3, 179);
            this.TrackBarPictureBox.Name = "TrackBarPictureBox";
            this.TrackBarPictureBox.Size = new System.Drawing.Size(617, 29);
            this.TrackBarPictureBox.TabIndex = 4;
            this.TrackBarPictureBox.TabStop = false;
            this.TrackBarPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TrackBarPictureBox_Paint);
            this.TrackBarPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBarPictureBox_MouseDown);
            this.TrackBarPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrackBarPictureBox_MouseMove);
            this.TrackBarPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarPictureBox_MouseUp);
            this.TrackBarPictureBox.Resize += new System.EventHandler(this.TrackBarPictureBox_Resize);
            // 
            // TickTimer
            // 
            this.TickTimer.Enabled = true;
            this.TickTimer.Interval = 33;
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(185, 6);
            // 
            // PlaylistsTreeViewerMenuItem
            // 
            this.PlaylistsTreeViewerMenuItem.Name = "PlaylistsTreeViewerMenuItem";
            this.PlaylistsTreeViewerMenuItem.Size = new System.Drawing.Size(188, 22);
            this.PlaylistsTreeViewerMenuItem.Text = "Playlists Tree Viewer...";
            this.PlaylistsTreeViewerMenuItem.Click += new System.EventHandler(this.PlaylistsTreeViewerMenuItem_Click);
            // 
            // MusicPlayerGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 335);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MusicPlayerGui";
            this.Text = "Music Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VolumePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumVisualizerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl PlaylistControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button PreviousTrackButton;
        private System.Windows.Forms.Button PlayTrackButton;
        private System.Windows.Forms.Button PauseTrackButton;
        private System.Windows.Forms.Button StopTrackButton;
        private System.Windows.Forms.Button NextTrackButton;
        private System.Windows.Forms.Button RewindTrackButton;
        private System.Windows.Forms.Button MuteButton;
        private System.Windows.Forms.PictureBox TrackBarPictureBox;
        private System.Windows.Forms.ToolStripMenuItem TrackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFilesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewPlaylistMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SavePlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem RemovePlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllPlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlaybackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VolumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MuteVolumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IncreaseVolumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DecreaseVolumeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RewindMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreviousMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ShuffleMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem PlayOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SequentialPlayOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomPlayOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepeatOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveTrackMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveAllTracksMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenPlaylistMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.PictureBox VolumePictureBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel VolumeLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel CurrentPositionLabel;
        private System.Windows.Forms.Timer TickTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox SpectrumVisualizerPictureBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem EditTrackTagsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem PlaylistsTreeViewerMenuItem;
    }
}