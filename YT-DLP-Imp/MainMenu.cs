using System.Diagnostics;

namespace YT_DLP_Imp
{
    public partial class MainMenu : Form
    {
        string argumentCluster;
        string FinalArguments;

        private List<TextBox> inputTextBoxes = new List<TextBox>();

        public MainMenu()
        {
            InitializeComponent();

            inputTextBoxes.Add(textBoxURL);
            inputTextBoxes.Add(textBoxFormat);
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
                inputs.Add(input);
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
    }
}