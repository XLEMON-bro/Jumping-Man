using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Jumping_Man.GameForms
{
    public partial class Level1Screen : UserControl
    {
        private readonly MainForm MainForm;
        private readonly Control MenuControl;
        private readonly GamePause gamePause;
        SoundPlayer gameWin = new SoundPlayer();
        SoundPlayer coinCollect = new SoundPlayer();
        SoundPlayer jump = new SoundPlayer();

        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;

        int jumpSpeed = 10;
        int force = 10;
        int maxForce = 10;
        int score = 0;

        public Level1Screen()
        {
            InitializeComponent();
        }

        public Level1Screen(MainForm MainForm,Control MenuControl):this()
        {
            this.MainForm = MainForm;
            this.MenuControl = MenuControl;
            gamePause = new GamePause(this, MainForm, MenuControl);
            gameWin.Stream = GameResources.gameWin;
            coinCollect.Stream = GameResources.coinCollect;
            jump.Stream = GameResources.jump;
        }
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(goLeft == false)
                    Player.Image = GameResources.HeroReverse;

                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(goRight == false)
                    Player.Image = GameResources.Hero;

                goRight = true;
            }
            if (e.KeyCode == Keys.Up && !goUp)
            {
                goUp = true;
                if (force > 0)
                    jump.Play();
            }
            if(e.KeyCode == Keys.Escape)
            {
                this.MainForm.Controls.Clear();
                this.MainForm.Controls.Add(gamePause);
            }
            base.OnPreviewKeyDown(e);
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                Player.Image = GameResources.HeroWaitReverse;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                Player.Image = GameResources.HeroWait;
            }
            if (goUp)
            {
                goUp = false;
            }
        }

        private void Level1Timer_Tick(object sender, EventArgs e)
        {
            if (Player.Bounds.IntersectsWith(ChestPtBox.Bounds))
            {
                gameWin.Play();

                Thread.Sleep(1500);

                this.MainForm.level1Passed = true;

                Level1Timer.Stop();

                this.MainForm.Controls.Clear();
                this.MainForm.Controls.Add(new EndLevelScreen(MainForm, MenuControl, GetLevelResult(score)));
            }

            if(jumpSpeed != 0)
            {
                Player.Top += jumpSpeed;
            }

            if (goUp && force < 0)
            {
                goUp = false;
            }

            if (goLeft)
            {
                Player.Left -= 5;
            }

            if (goRight)
            {
                Player.Left += 5;
            }

            if (goUp)
            {
                jumpSpeed = -14;
                force -= 1;
                if(FlyPowerLabel.Text.Length > 0)
                    FlyPowerLabel.Text = FlyPowerLabel.Text.Remove(0);
            }
            else
            {
                jumpSpeed = 7;
            }

            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag == "floor")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds) && !goUp)
                    {
                        jumpSpeed = 0;
                        if(force < maxForce) 
                        { 
                            force += 2;
                            FlyPowerLabel.Text += "/";
                        }
                        Player.Top = i.Top - Player.Height;
                    }
                }

                if (i is PictureBox && i.Tag == "water")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds))
                    {
                        if(Player.Top > i.Top)
                        {
                            this.MainForm.Controls.Clear();
                            this.MainForm.Controls.Add(new EndLevelScreen(MainForm,MenuControl,EndLevelStatus.Death));
                        }
                    }
                }

                if (i is PictureBox && i.Tag == "leftWall")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds))
                    {
                        Player.Left = i.Left + Player.Width;
                    }
                }


                if (i is PictureBox && i.Tag == "rightWall")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds))
                    {
                        Player.Left = i.Left - Player.Width;
                    }
                }

                if (i is PictureBox && i.Tag == "coin")
                {
                    if (Player.Bounds.IntersectsWith(i.Bounds) && !goUp)
                    {
                        this.Controls.Remove(i);
                        score++;
                        scoreDisplay.Text = ": " + (score).ToString();

                        coinCollect.Play();
                    }
                }
            }
        }

        private EndLevelStatus GetLevelResult(int score)
        {
            if (score == 0)
                return EndLevelStatus.Win;

            if (score < 5)
                return EndLevelStatus.OneStar;

            if (score < 10)
                return EndLevelStatus.TwoStars;

            return EndLevelStatus.ThreeStars;
        }
    }
}
