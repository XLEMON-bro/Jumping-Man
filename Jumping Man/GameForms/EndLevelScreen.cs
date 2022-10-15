using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jumping_Man.GameForms
{
    public partial class EndLevelScreen : UserControl
    {
        private MainForm MainForm;
        private Control MenuControl;

        public EndLevelScreen()
        {
            InitializeComponent();
            this.DeathLabel.Hide();
            this.levelStar1.Hide();
            this.levelStar2.Hide();
            this.levelStar3.Hide();
            this.WinLabel.Hide();
        }

        public EndLevelScreen(MainForm mainForm,Control menuControl, EndLevelStatus levelStatus) : this()
        {
            MainForm = mainForm;
            MenuControl = menuControl;
            SetComponent(levelStatus);
        }

        private void SetComponent(EndLevelStatus status)
        {
            if(status == EndLevelStatus.Death)
            {
                this.DeathLabel.Show();
                return;
            }

            if(status == EndLevelStatus.ThreeStars)
            {
                this.levelStar1.Show();
                this.levelStar2.Show();
                this.levelStar3.Show();
                this.WinLabel.Show();
            }

            if (status == EndLevelStatus.TwoStars)
            {
                this.levelStar1.Show();
                this.levelStar2.Show();
                this.WinLabel.Show();
            }

            if (status == EndLevelStatus.OneStar)
            {
                this.levelStar1.Show();
                this.WinLabel.Show();
            }

            if(status == EndLevelStatus.Win)
            {
                this.WinLabel.Show();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(MenuControl);
        }
    }
}
