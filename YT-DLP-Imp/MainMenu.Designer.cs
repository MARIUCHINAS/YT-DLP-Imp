namespace YT_DLP_Imp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            FinalArgumentBox = new RichTextBox();
            button1 = new Button();
            textBoxURL = new TextBox();
            labelURL = new Label();
            labelFormat = new Label();
            textBoxFormat = new TextBox();
            checkBoxAudio = new CheckBox();
            linkLabelGithub = new LinkLabel();
            textBoxMaxFileSize = new TextBox();
            labelMaxFileSize = new Label();
            labelMinFileSize = new Label();
            textBoxMinFileSize = new TextBox();
            labelMaxDownloads = new Label();
            textBoxMaxDownloads = new TextBox();
            ThumbNailcheckBox = new CheckBox();
            AllThumbnailcheckBox = new CheckBox();
            checkBoxWriteSubtitles = new CheckBox();
            labelAudioQuality = new Label();
            textBoxAudioQuality = new TextBox();
            WriteCommentscheckBox = new CheckBox();
            SuspendLayout();
            // 
            // FinalArgumentBox
            // 
            FinalArgumentBox.Location = new Point(468, 245);
            FinalArgumentBox.Name = "FinalArgumentBox";
            FinalArgumentBox.Size = new Size(320, 158);
            FinalArgumentBox.TabIndex = 0;
            FinalArgumentBox.Text = "";
            FinalArgumentBox.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(694, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.BackColor = Color.FromArgb(171, 42, 65);
            textBoxURL.Location = new Point(47, 12);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(277, 27);
            textBoxURL.TabIndex = 2;
            textBoxURL.TextChanged += textBox1_TextChanged;
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelURL.ForeColor = Color.FromArgb(171, 42, 65);
            labelURL.Location = new Point(6, 15);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(39, 18);
            labelURL.TabIndex = 3;
            labelURL.Text = "URL";
            // 
            // labelFormat
            // 
            labelFormat.AutoSize = true;
            labelFormat.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFormat.ForeColor = Color.FromArgb(171, 42, 65);
            labelFormat.Location = new Point(6, 60);
            labelFormat.Name = "labelFormat";
            labelFormat.Size = new Size(57, 18);
            labelFormat.TabIndex = 4;
            labelFormat.Text = "Format";
            labelFormat.Click += label1_Click;
            // 
            // textBoxFormat
            // 
            textBoxFormat.BackColor = Color.FromArgb(171, 42, 65);
            textBoxFormat.Location = new Point(69, 55);
            textBoxFormat.Name = "textBoxFormat";
            textBoxFormat.Size = new Size(255, 27);
            textBoxFormat.TabIndex = 5;
            textBoxFormat.TextChanged += textBox1_TextChanged_1;
            // 
            // checkBoxAudio
            // 
            checkBoxAudio.AutoSize = true;
            checkBoxAudio.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxAudio.ForeColor = Color.FromArgb(171, 42, 65);
            checkBoxAudio.Location = new Point(330, 58);
            checkBoxAudio.Name = "checkBoxAudio";
            checkBoxAudio.Size = new Size(100, 22);
            checkBoxAudio.TabIndex = 6;
            checkBoxAudio.Text = "Audio File";
            checkBoxAudio.UseVisualStyleBackColor = true;
            checkBoxAudio.CheckedChanged += checkBoxAudio_CheckedChanged;
            // 
            // linkLabelGithub
            // 
            linkLabelGithub.AutoSize = true;
            linkLabelGithub.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabelGithub.Location = new Point(6, 417);
            linkLabelGithub.Name = "linkLabelGithub";
            linkLabelGithub.Size = new Size(74, 24);
            linkLabelGithub.TabIndex = 7;
            linkLabelGithub.TabStop = true;
            linkLabelGithub.Text = "Github";
            linkLabelGithub.LinkClicked += linkLabelGithub_LinkClicked;
            // 
            // textBoxMaxFileSize
            // 
            textBoxMaxFileSize.BackColor = Color.FromArgb(171, 42, 65);
            textBoxMaxFileSize.Location = new Point(114, 119);
            textBoxMaxFileSize.Name = "textBoxMaxFileSize";
            textBoxMaxFileSize.Size = new Size(210, 27);
            textBoxMaxFileSize.TabIndex = 8;
            textBoxMaxFileSize.TextChanged += textBoxMaxFileSize_TextChanged;
            // 
            // labelMaxFileSize
            // 
            labelMaxFileSize.AutoSize = true;
            labelMaxFileSize.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaxFileSize.ForeColor = Color.FromArgb(171, 42, 65);
            labelMaxFileSize.Location = new Point(6, 122);
            labelMaxFileSize.Name = "labelMaxFileSize";
            labelMaxFileSize.Size = new Size(102, 18);
            labelMaxFileSize.TabIndex = 9;
            labelMaxFileSize.Text = "Max File Size";
            // 
            // labelMinFileSize
            // 
            labelMinFileSize.AutoSize = true;
            labelMinFileSize.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinFileSize.ForeColor = Color.FromArgb(171, 42, 65);
            labelMinFileSize.Location = new Point(6, 155);
            labelMinFileSize.Name = "labelMinFileSize";
            labelMinFileSize.Size = new Size(99, 18);
            labelMinFileSize.TabIndex = 11;
            labelMinFileSize.Text = "Min File Size";
            // 
            // textBoxMinFileSize
            // 
            textBoxMinFileSize.BackColor = Color.FromArgb(171, 42, 65);
            textBoxMinFileSize.Location = new Point(114, 152);
            textBoxMinFileSize.Name = "textBoxMinFileSize";
            textBoxMinFileSize.Size = new Size(210, 27);
            textBoxMinFileSize.TabIndex = 10;
            textBoxMinFileSize.TextChanged += textBoxMinFileSize_TextChanged;
            // 
            // labelMaxDownloads
            // 
            labelMaxDownloads.AutoSize = true;
            labelMaxDownloads.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaxDownloads.ForeColor = Color.FromArgb(171, 42, 65);
            labelMaxDownloads.Location = new Point(6, 197);
            labelMaxDownloads.Name = "labelMaxDownloads";
            labelMaxDownloads.Size = new Size(119, 18);
            labelMaxDownloads.TabIndex = 13;
            labelMaxDownloads.Text = "Max Downloads";
            // 
            // textBoxMaxDownloads
            // 
            textBoxMaxDownloads.BackColor = Color.FromArgb(171, 42, 65);
            textBoxMaxDownloads.Location = new Point(131, 193);
            textBoxMaxDownloads.Name = "textBoxMaxDownloads";
            textBoxMaxDownloads.Size = new Size(193, 27);
            textBoxMaxDownloads.TabIndex = 12;
            textBoxMaxDownloads.TextChanged += textBoxMaxDownloads_TextChanged;
            // 
            // ThumbNailcheckBox
            // 
            ThumbNailcheckBox.AutoSize = true;
            ThumbNailcheckBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ThumbNailcheckBox.ForeColor = Color.FromArgb(171, 42, 65);
            ThumbNailcheckBox.Location = new Point(6, 291);
            ThumbNailcheckBox.Name = "ThumbNailcheckBox";
            ThumbNailcheckBox.Size = new Size(182, 22);
            ThumbNailcheckBox.TabIndex = 14;
            ThumbNailcheckBox.Text = "Download Thumbnail ";
            ThumbNailcheckBox.UseVisualStyleBackColor = true;
            ThumbNailcheckBox.CheckedChanged += ThumbNailcheckBox_CheckedChanged;
            // 
            // AllThumbnailcheckBox
            // 
            AllThumbnailcheckBox.AutoSize = true;
            AllThumbnailcheckBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AllThumbnailcheckBox.ForeColor = Color.FromArgb(171, 42, 65);
            AllThumbnailcheckBox.Location = new Point(6, 319);
            AllThumbnailcheckBox.Name = "AllThumbnailcheckBox";
            AllThumbnailcheckBox.Size = new Size(210, 22);
            AllThumbnailcheckBox.TabIndex = 15;
            AllThumbnailcheckBox.Text = "Download All Thumbnails ";
            AllThumbnailcheckBox.UseVisualStyleBackColor = true;
            AllThumbnailcheckBox.CheckedChanged += AllThumbnailcheckBox_CheckedChanged;
            // 
            // checkBoxWriteSubtitles
            // 
            checkBoxWriteSubtitles.AutoSize = true;
            checkBoxWriteSubtitles.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxWriteSubtitles.ForeColor = Color.FromArgb(171, 42, 65);
            checkBoxWriteSubtitles.Location = new Point(6, 360);
            checkBoxWriteSubtitles.Name = "checkBoxWriteSubtitles";
            checkBoxWriteSubtitles.Size = new Size(198, 22);
            checkBoxWriteSubtitles.TabIndex = 16;
            checkBoxWriteSubtitles.Text = "Write Subtitles To a File";
            checkBoxWriteSubtitles.UseVisualStyleBackColor = true;
            checkBoxWriteSubtitles.CheckedChanged += checkBoxWriteSubtitles_CheckedChanged;
            // 
            // labelAudioQuality
            // 
            labelAudioQuality.AutoSize = true;
            labelAudioQuality.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAudioQuality.ForeColor = Color.FromArgb(171, 42, 65);
            labelAudioQuality.Location = new Point(6, 91);
            labelAudioQuality.Name = "labelAudioQuality";
            labelAudioQuality.Size = new Size(101, 18);
            labelAudioQuality.TabIndex = 4;
            labelAudioQuality.Text = "Audio Quality";
            labelAudioQuality.Click += label1_Click;
            // 
            // textBoxAudioQuality
            // 
            textBoxAudioQuality.BackColor = Color.FromArgb(171, 42, 65);
            textBoxAudioQuality.Location = new Point(113, 86);
            textBoxAudioQuality.Name = "textBoxAudioQuality";
            textBoxAudioQuality.Size = new Size(211, 27);
            textBoxAudioQuality.TabIndex = 5;
            textBoxAudioQuality.TextChanged += textBox1_TextChanged_1;
            // 
            // WriteCommentscheckBox
            // 
            WriteCommentscheckBox.AutoSize = true;
            WriteCommentscheckBox.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            WriteCommentscheckBox.ForeColor = Color.FromArgb(171, 42, 65);
            WriteCommentscheckBox.Location = new Point(6, 249);
            WriteCommentscheckBox.Name = "WriteCommentscheckBox";
            WriteCommentscheckBox.Size = new Size(146, 22);
            WriteCommentscheckBox.TabIndex = 17;
            WriteCommentscheckBox.Text = "Write Comments";
            WriteCommentscheckBox.UseVisualStyleBackColor = true;
            WriteCommentscheckBox.CheckedChanged += WriteCommentscheckBox_CheckedChanged;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 32, 33);
            ClientSize = new Size(800, 450);
            Controls.Add(WriteCommentscheckBox);
            Controls.Add(checkBoxWriteSubtitles);
            Controls.Add(AllThumbnailcheckBox);
            Controls.Add(ThumbNailcheckBox);
            Controls.Add(labelMaxDownloads);
            Controls.Add(textBoxMaxDownloads);
            Controls.Add(labelMinFileSize);
            Controls.Add(textBoxMinFileSize);
            Controls.Add(labelMaxFileSize);
            Controls.Add(textBoxMaxFileSize);
            Controls.Add(linkLabelGithub);
            Controls.Add(checkBoxAudio);
            Controls.Add(textBoxAudioQuality);
            Controls.Add(labelAudioQuality);
            Controls.Add(textBoxFormat);
            Controls.Add(labelFormat);
            Controls.Add(labelURL);
            Controls.Add(textBoxURL);
            Controls.Add(button1);
            Controls.Add(FinalArgumentBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "Youtube Downloader";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox FinalArgumentBox;
        private Button button1;
        private TextBox textBoxURL;
        private Label labelURL;
        private Label labelFormat;
        private TextBox textBoxFormat;
        private CheckBox checkBoxAudio;
        private LinkLabel linkLabelGithub;
        private TextBox textBoxMaxFileSize;
        private Label labelMaxFileSize;
        private Label labelMinFileSize;
        private TextBox textBoxMinFileSize;
        private Label labelMaxDownloads;
        private TextBox textBoxMaxDownloads;
        private CheckBox ThumbNailcheckBox;
        private CheckBox AllThumbnailcheckBox;
        private CheckBox checkBoxWriteSubtitles;
        private Label labelAudioQuality;
        private TextBox textBoxAudioQuality;
        private CheckBox WriteCommentscheckBox;
    }
}