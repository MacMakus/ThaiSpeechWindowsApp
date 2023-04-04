using System.Speech.Synthesis;

namespace ThaiSpeechWindowsApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewThaiWordButton_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "ThaiWord1.txt");
            string[] words = File.ReadAllText(filePath).Split(',');
            int index = new Random().Next(0, words.Length);
            ThaiWordLabel.Text = words[index];
        }

        private void ReadSpeechButton_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Rate = -4;

            foreach (var items in speech.GetInstalledVoices())
            {
                if (items.VoiceInfo.Name.Contains("Pattara"))
                {
                    speech.SelectVoice(items.VoiceInfo.Name);
                    speech.Speak(ThaiWordLabel.Text);
                }
            }
        }
    }
}