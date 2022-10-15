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
    public partial class LevelScreen : UserControl
    {
        private Control MenuControl;
        private MainForm MainForm;

        public LevelScreen()
        {
            InitializeComponent();
            this.Level1Passed.Hide();
            this.Level2Button.Hide();
            this.Level2Passed.Hide();
            this.Level3Button.Hide();
            this.Level3Passed.Hide();
        }

        public LevelScreen(MainForm MainForm, Control MainMenuForm) : this()
        {
            this.MainForm = MainForm; 
            this.MenuControl = MainMenuForm;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(this.MenuControl);
        }

        private void Level1Button_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(new Level1Screen(this.MainForm, this.MenuControl));
        }

        private void Level2Button_Click(object sender, EventArgs e)
        {

        }

        private void Level3Button_Click(object sender, EventArgs e)
        {

        }

        private void LevelsScreenTimer_Tick(object sender, EventArgs e)
        {
            if (MainForm.level1Passed)
            {
                this.Level1Passed.Show();
                this.Level2Button.Show();
            }
            if (MainForm.level2Passed)
            {
                this.Level2Passed.Show();
                this.Level3Button.Show();
            }
            if (MainForm.level3Passed)
            {
                this.Level3Passed.Show();
            }
        }
    }
}
