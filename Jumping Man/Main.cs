using Jumping_Man.GameForms;
using System.Media;

namespace Jumping_Man
{
    public partial class MainForm : Form
    {
        public bool level1Passed = false;
        public bool level2Passed = false;
        public bool level3Passed = false;
        private bool musicIsPlayed = false;
        SoundPlayer BackgroungMusic = new SoundPlayer();

        public MainForm()
        {
            InitializeComponent();
            var menu = new MenuScreen(this);
            this.MainGamePanel.Controls.Add(menu);
            BackgroungMusic.Stream = GameResources.Fluffing_a_Duck;
            BackgroungMusic.PlayLooping();
            musicIsPlayed = true;
        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            if ((this.Controls[0] is Level1Screen || this.Controls[0] is Level2Screen || this.Controls[0] is Level3Screen) && musicIsPlayed) 
            { 
                BackgroungMusic.Stop();
                musicIsPlayed = false;
            }
            if(!musicIsPlayed && !(this.Controls[0] is Level1Screen || this.Controls[0] is Level2Screen || this.Controls[0] is Level3Screen))
            {
                BackgroungMusic.PlayLooping();
                musicIsPlayed = true;
            }
        }
    }
}