using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Policy;

namespace YT_DLP_Imp
{
    public partial class MainMenu : Form
    {
        string argumentCluster;
        string FinalArguments;

        string urlGithub = "https://github.com/MARIUCHINAS/YT-DLP-Imp";

        private List<TextBox> inputTextBoxes = new List<TextBox>();

        public MainMenu()
        {
            InitializeComponent();

            inputTextBoxes.Add(textBoxURL);
            inputTextBoxes.Add(textBoxFormat);
            inputTextBoxes.Add(textBoxMaxFileSize);
            inputTextBoxes.Add(textBoxMinFileSize);
            inputTextBoxes.Add(textBoxMaxDownloads);
            inputTextBoxes.Add(textBoxAudioQuality);
        }

        public void Downloader()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string scriptPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string scriptDirectory = System.IO.Path.GetDirectoryName(scriptPath);
            string command = "cmd.exe";
            string arguments = "/k " + FinalArguments; // Use "/k" instead of "/c" to keep the command prompt open

            ProcessStartInfo processStartInfo = new ProcessStartInfo(command, arguments);
            processStartInfo.WorkingDirectory = scriptDirectory;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = false;

            try
            {
                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalArguments = FinalArgumentBox.Text;
            Downloader();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            argumentCluster = "yt-dlp.exe";
            FinalArgumentBox.Text = argumentCluster;
        }

        private void UpdateArgumentCluster()
        {
            List<string> inputs = new List<string>();

            foreach (TextBox textBox in inputTextBoxes)
            {
                string input = textBox.Text;
                if (textBox.Name == "textBoxFormat" && !string.IsNullOrEmpty(input))
                {

                    if (checkBoxAudio.Checked)
                    {
                        input = "-x --audio-format " + input;
                    }
                    else
                    {
                        input = "-f " + input;
                    }


                }

                if (textBox.Name == "textBoxMaxFileSize" && !string.IsNullOrEmpty(input))
                {

                    input = "--max-filesize " + input;
                }
                if (textBox.Name == "textBoxMinFileSize" && !string.IsNullOrEmpty(input))
                {

                    input = "--min-filesize " + input;
                }
                if (textBox.Name == "textBoxMaxDownloads" && !string.IsNullOrEmpty(input))
                {
                    input = "--max-downloads " + input;
                }

                inputs.Add(input);
            }

            if (ThumbNailcheckBox.Checked)
            {
                inputs.Add("--write-thumbnail");
            }

            if (AllThumbnailcheckBox.Checked)
            {
                inputs.Add("--write-all-thumbnails");
            }

            if (checkBoxWriteSubtitles.Checked)
            {
                inputs.Add("--write-subs");
            }
            else
            {
                inputs.Add("--no-write-subs");
            }

            argumentCluster = "yt-dlp.exe " + string.Join(" ", inputs);
            FinalArgumentBox.Text = argumentCluster;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void checkBoxAudio_CheckedChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo GithubstartInfo = new ProcessStartInfo("cmd", $"/c start {urlGithub}");
            GithubstartInfo.CreateNoWindow = true;
            GithubstartInfo.UseShellExecute = false;
            Process.Start(GithubstartInfo);
        }

        private void textBoxMaxFileSize_TextChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void textBoxMinFileSize_TextChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void textBoxMaxDownloads_TextChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }

        private void ThumbNailcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ThumbNailcheckBox.Checked)
            {
                AllThumbnailcheckBox.Checked = false;
            }
            UpdateArgumentCluster();
        }

        private void AllThumbnailcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllThumbnailcheckBox.Checked)
            {
                ThumbNailcheckBox.Checked = false;
            }

            UpdateArgumentCluster();
        }

        private void checkBoxWriteSubtitles_CheckedChanged(object sender, EventArgs e)
        {
            UpdateArgumentCluster();
        }
    }
}