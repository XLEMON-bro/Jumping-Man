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
        private Level1Screen level1;
        private Level2Screen level2;
        private Level3Screen level3;

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
            level1 = new Level1Screen(this.MainForm, this.MenuControl);
            level2 = new Level2Screen(this.MainForm, this.MenuControl);
            level3 = new Level3Screen(this.MainForm, this.MenuControl);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(this.MenuControl);
        }

        private void Level1Button_Click(object sender, EventArgs e)
        {
            level1?.Dispose();
            level1 = new Level1Screen(this.MainForm, this.MenuControl);
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(level1);
        }

        private void Level2Button_Click(object sender, EventArgs e)
        {
            level2?.Dispose();
            level2 = new Level2Screen(this.MainForm, this.MenuControl);
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(level2);
        }

        private void Level3Button_Click(object sender, EventArgs e)
        {
            level3?.Dispose();
            level3 = new Level3Screen(this.MainForm, this.MenuControl);
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(level3);
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
