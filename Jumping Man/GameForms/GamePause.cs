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
    public partial class GamePause : UserControl
    {
        private readonly Control levelScreen;
        private readonly Control MenuControl;
        private readonly MainForm MainForm;

        public GamePause()
        {
            InitializeComponent();
        }
        public GamePause(Control level, MainForm mainForm, Control menuControl) :this()
        {
            levelScreen = level;
            MainForm = mainForm;
            MenuControl = menuControl;
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(MenuControl);
        }

        private void BacktoGameButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(levelScreen);
        }
    }
}
