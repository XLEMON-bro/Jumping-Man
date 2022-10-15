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
    public partial class MenuScreen : UserControl
    {
        private MainForm MainForm;
        private readonly LevelScreen levelScreen;
        public MenuScreen()
        {
            InitializeComponent();
        }

        public MenuScreen(MainForm MainForm): this()
        {
            this.MainForm = MainForm;
            levelScreen = new LevelScreen(this.MainForm, this);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Controls.Clear();
            this.MainForm.Controls.Add(levelScreen);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.MainForm.Close();
        }
    }
}
