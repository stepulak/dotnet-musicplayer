namespace MusicPlayer
{
    partial class TrackTagEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AlbumTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.YearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveTagsButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.FiletypeLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.BitrateLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(66, 27);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(117, 20);
            this.TitleTextBox.TabIndex = 4;
            // 
            // AlbumTextBox
            // 
            this.AlbumTextBox.Location = new System.Drawing.Point(66, 55);
            this.AlbumTextBox.Name = "AlbumTextBox";
            this.AlbumTextBox.Size = new System.Drawing.Size(117, 20);
            this.AlbumTextBox.TabIndex = 5;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(66, 81);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(117, 20);
            this.AuthorTextBox.TabIndex = 6;
            // 
            // YearNumericUpDown
            // 
            this.YearNumericUpDown.Location = new System.Drawing.Point(66, 136);
            this.YearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.YearNumericUpDown.Name = "YearNumericUpDown";
            this.YearNumericUpDown.Size = new System.Drawing.Size(117, 20);
            this.YearNumericUpDown.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenreTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.SaveTagsButton);
            this.groupBox1.Controls.Add(this.AuthorTextBox);
            this.groupBox1.Controls.Add(this.YearNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AlbumTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 226);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track tags";
            // 
            // SaveTagsButton
            // 
            this.SaveTagsButton.Location = new System.Drawing.Point(27, 183);
            this.SaveTagsButton.Name = "SaveTagsButton";
            this.SaveTagsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveTagsButton.TabIndex = 8;
            this.SaveTagsButton.Text = "Save";
            this.SaveTagsButton.UseVisualStyleBackColor = true;
            this.SaveTagsButton.Click += new System.EventHandler(this.SaveTagsButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(108, 183);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SizeLabel);
            this.groupBox2.Controls.Add(this.BitrateLabel);
            this.groupBox2.Controls.Add(this.LenghtLabel);
            this.groupBox2.Controls.Add(this.FiletypeLabel);
            this.groupBox2.Controls.Add(this.FilenameLabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(239, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 222);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File properties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "File Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Length:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bitrate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Size:";
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(88, 26);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(49, 13);
            this.FilenameLabel.TabIndex = 5;
            this.FilenameLabel.Text = "Filename";
            // 
            // FiletypeLabel
            // 
            this.FiletypeLabel.AutoSize = true;
            this.FiletypeLabel.Location = new System.Drawing.Point(88, 61);
            this.FiletypeLabel.Name = "FiletypeLabel";
            this.FiletypeLabel.Size = new System.Drawing.Size(43, 13);
            this.FiletypeLabel.TabIndex = 6;
            this.FiletypeLabel.Text = "Filetype";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(88, 98);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(37, 13);
            this.LenghtLabel.TabIndex = 7;
            this.LenghtLabel.Text = "00000";
            // 
            // BitrateLabel
            // 
            this.BitrateLabel.AutoSize = true;
            this.BitrateLabel.Location = new System.Drawing.Point(88, 135);
            this.BitrateLabel.Name = "BitrateLabel";
            this.BitrateLabel.Size = new System.Drawing.Size(37, 13);
            this.BitrateLabel.TabIndex = 8;
            this.BitrateLabel.Text = "Bitrate";
            this.BitrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(88, 169);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(29, 13);
            this.SizeLabel.TabIndex = 9;
            this.SizeLabel.Text = "0MB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(66, 107);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(117, 20);
            this.GenreTextBox.TabIndex = 11;
            // 
            // TrackTagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrackTagEditor";
            this.Text = "Track Tag Properties";
            this.Load += new System.EventHandler(this.TrackTagEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox AlbumTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.NumericUpDown YearNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveTagsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label BitrateLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.Label FiletypeLabel;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label label10;
    }
}