namespace Jumping_Man.GameForms
{
    partial class Level1Screen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroundPictureBox = new System.Windows.Forms.PictureBox();
            this.Level1Timer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.ChestPtBox = new System.Windows.Forms.PictureBox();
            this.scoreDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FlyPowerLabel = new System.Windows.Forms.Label();
            this.LeftWallPtBox = new System.Windows.Forms.PictureBox();
            this.RightWallPtBox = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroundPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestPtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWallPtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWallPtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            this.SuspendLayout();
            // 
            // GroundPictureBox
            // 
            this.GroundPictureBox.BackgroundImage = global::Jumping_Man.GameResources.Grass2_5d;
            this.GroundPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroundPictureBox.Location = new System.Drawing.Point(0, 866);
            this.GroundPictureBox.Name = "GroundPictureBox";
            this.GroundPictureBox.Size = new System.Drawing.Size(900, 62);
            this.GroundPictureBox.TabIndex = 0;
            this.GroundPictureBox.TabStop = false;
            this.GroundPictureBox.Tag = "floor";
            // 
            // Level1Timer
            // 
            this.Level1Timer.Enabled = true;
            this.Level1Timer.Interval = 10;
            this.Level1Timer.Tick += new System.EventHandler(this.Level1Timer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Image = global::Jumping_Man.GameResources.Hero;
            this.Player.Location = new System.Drawing.Point(35, 781);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(34, 49);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Tag = "player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(497, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "floor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(991, 728);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 38);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "floor";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1257, 592);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(245, 38);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "floor";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(167, 561);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(243, 38);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "floor";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(991, 495);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(167, 38);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "floor";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(229, 352);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(156, 38);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "floor";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(0, 229);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(195, 38);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "floor";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(317, 144);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(238, 38);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "floor";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(655, 185);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(329, 38);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "floor";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::Jumping_Man.GameResources.Grass;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(1102, 153);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(397, 38);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "floor";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Image = global::Jumping_Man.GameResources.WaterAnimated;
            this.pictureBox11.Location = new System.Drawing.Point(897, 866);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(605, 62);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "water";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox12.Location = new System.Drawing.Point(474, 610);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox13.Location = new System.Drawing.Point(35, 495);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(31, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 14;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coin";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox14.Location = new System.Drawing.Point(931, 800);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(31, 30);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coin";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox15.Location = new System.Drawing.Point(1038, 446);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(31, 30);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 16;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "coin";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox16.Location = new System.Drawing.Point(1448, 484);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(31, 30);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 17;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coin";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox17.Location = new System.Drawing.Point(858, 527);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(31, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 18;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "coin";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox18.Location = new System.Drawing.Point(754, 402);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(31, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 19;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coin";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox19.Location = new System.Drawing.Point(576, 343);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(31, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 20;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "coin";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox20.Location = new System.Drawing.Point(317, 525);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(31, 30);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 21;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "coin";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox21.Location = new System.Drawing.Point(79, 193);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(31, 30);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 22;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox22.Location = new System.Drawing.Point(406, 104);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(31, 30);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 23;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "coin";
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox23.Location = new System.Drawing.Point(1022, 237);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(31, 30);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 24;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "coin";
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox24.Image = global::Jumping_Man.GameResources.CoinAnimated;
            this.pictureBox24.Location = new System.Drawing.Point(1173, 85);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(31, 30);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coin";
            // 
            // ChestPtBox
            // 
            this.ChestPtBox.BackColor = System.Drawing.Color.Transparent;
            this.ChestPtBox.BackgroundImage = global::Jumping_Man.GameResources.Chest;
            this.ChestPtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChestPtBox.Location = new System.Drawing.Point(1417, 104);
            this.ChestPtBox.Name = "ChestPtBox";
            this.ChestPtBox.Size = new System.Drawing.Size(62, 50);
            this.ChestPtBox.TabIndex = 26;
            this.ChestPtBox.TabStop = false;
            this.ChestPtBox.Tag = "chest";
            // 
            // scoreDisplay
            // 
            this.scoreDisplay.AutoSize = true;
            this.scoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.scoreDisplay.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreDisplay.ForeColor = System.Drawing.Color.Black;
            this.scoreDisplay.Location = new System.Drawing.Point(88, 11);
            this.scoreDisplay.Name = "scoreDisplay";
            this.scoreDisplay.Size = new System.Drawing.Size(66, 54);
            this.scoreDisplay.TabIndex = 27;
            this.scoreDisplay.Text = ": 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Jump:";
            // 
            // FlyPowerLabel
            // 
            this.FlyPowerLabel.AutoSize = true;
            this.FlyPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlyPowerLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FlyPowerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FlyPowerLabel.Location = new System.Drawing.Point(104, 53);
            this.FlyPowerLabel.Name = "FlyPowerLabel";
            this.FlyPowerLabel.Size = new System.Drawing.Size(82, 40);
            this.FlyPowerLabel.TabIndex = 29;
            this.FlyPowerLabel.Text = "/////";
            // 
            // LeftWallPtBox
            // 
            this.LeftWallPtBox.BackColor = System.Drawing.Color.Transparent;
            this.LeftWallPtBox.Location = new System.Drawing.Point(-28, 0);
            this.LeftWallPtBox.Name = "LeftWallPtBox";
            this.LeftWallPtBox.Size = new System.Drawing.Size(28, 913);
            this.LeftWallPtBox.TabIndex = 30;
            this.LeftWallPtBox.TabStop = false;
            this.LeftWallPtBox.Tag = "leftWall";
            // 
            // RightWallPtBox
            // 
            this.RightWallPtBox.BackColor = System.Drawing.Color.Transparent;
            this.RightWallPtBox.Location = new System.Drawing.Point(1500, 0);
            this.RightWallPtBox.Name = "RightWallPtBox";
            this.RightWallPtBox.Size = new System.Drawing.Size(28, 913);
            this.RightWallPtBox.TabIndex = 31;
            this.RightWallPtBox.TabStop = false;
            this.RightWallPtBox.Tag = "rightWall";
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox25.BackgroundImage = global::Jumping_Man.GameResources.CoinInterface;
            this.pictureBox25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox25.Location = new System.Drawing.Point(26, 11);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(56, 54);
            this.pictureBox25.TabIndex = 32;
            this.pictureBox25.TabStop = false;
            // 
            // Level1Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jumping_Man.GameResources.Level2Background1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.RightWallPtBox);
            this.Controls.Add(this.LeftWallPtBox);
            this.Controls.Add(this.ChestPtBox);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.GroundPictureBox);
            this.Controls.Add(this.scoreDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlyPowerLabel);
            this.DoubleBuffered = true;
            this.Name = "Level1Screen";
            this.Size = new System.Drawing.Size(1502, 913);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.GroundPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChestPtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftWallPtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightWallPtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox GroundPictureBox;
        private System.Windows.Forms.Timer Level1Timer;
        private PictureBox Player;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox ChestPtBox;
        private Label scoreDisplay;
        private Label label1;
        private Label FlyPowerLabel;
        private PictureBox LeftWallPtBox;
        private PictureBox RightWallPtBox;
        private PictureBox pictureBox25;
    }
}
