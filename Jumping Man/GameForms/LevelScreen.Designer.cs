namespace Jumping_Man.GameForms
{
    partial class LevelScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Level1Button = new System.Windows.Forms.PictureBox();
            this.Level2Button = new System.Windows.Forms.PictureBox();
            this.Level3Button = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.Level1Passed = new System.Windows.Forms.PictureBox();
            this.Level2Passed = new System.Windows.Forms.PictureBox();
            this.Level3Passed = new System.Windows.Forms.PictureBox();
            this.LevelsScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Passed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Passed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Passed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Jumping_Man.GameResources.GameTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Level1Button
            // 
            this.Level1Button.BackColor = System.Drawing.Color.Transparent;
            this.Level1Button.BackgroundImage = global::Jumping_Man.GameResources.Level1LabelIMG;
            this.Level1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level1Button.Location = new System.Drawing.Point(527, 86);
            this.Level1Button.Name = "Level1Button";
            this.Level1Button.Size = new System.Drawing.Size(505, 178);
            this.Level1Button.TabIndex = 2;
            this.Level1Button.TabStop = false;
            this.Level1Button.Click += new System.EventHandler(this.Level1Button_Click);
            // 
            // Level2Button
            // 
            this.Level2Button.BackColor = System.Drawing.Color.Transparent;
            this.Level2Button.BackgroundImage = global::Jumping_Man.GameResources.Level2LabelIMG;
            this.Level2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level2Button.Location = new System.Drawing.Point(527, 342);
            this.Level2Button.Name = "Level2Button";
            this.Level2Button.Size = new System.Drawing.Size(505, 178);
            this.Level2Button.TabIndex = 3;
            this.Level2Button.TabStop = false;
            this.Level2Button.Click += new System.EventHandler(this.Level2Button_Click);
            // 
            // Level3Button
            // 
            this.Level3Button.BackColor = System.Drawing.Color.Transparent;
            this.Level3Button.BackgroundImage = global::Jumping_Man.GameResources.Level3LeabelIMG;
            this.Level3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Level3Button.Location = new System.Drawing.Point(527, 607);
            this.Level3Button.Name = "Level3Button";
            this.Level3Button.Size = new System.Drawing.Size(505, 178);
            this.Level3Button.TabIndex = 4;
            this.Level3Button.TabStop = false;
            this.Level3Button.Click += new System.EventHandler(this.Level3Button_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::Jumping_Man.GameResources.BackLabelIMG;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(1218, 801);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(272, 93);
            this.BackButton.TabIndex = 5;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Level1Passed
            // 
            this.Level1Passed.BackColor = System.Drawing.Color.Transparent;
            this.Level1Passed.BackgroundImage = global::Jumping_Man.GameResources.Level_Passed_IMG;
            this.Level1Passed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level1Passed.Location = new System.Drawing.Point(1075, 86);
            this.Level1Passed.Name = "Level1Passed";
            this.Level1Passed.Size = new System.Drawing.Size(184, 178);
            this.Level1Passed.TabIndex = 6;
            this.Level1Passed.TabStop = false;
            // 
            // Level2Passed
            // 
            this.Level2Passed.BackColor = System.Drawing.Color.Transparent;
            this.Level2Passed.BackgroundImage = global::Jumping_Man.GameResources.Level_Passed_IMG;
            this.Level2Passed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level2Passed.Location = new System.Drawing.Point(1075, 342);
            this.Level2Passed.Name = "Level2Passed";
            this.Level2Passed.Size = new System.Drawing.Size(184, 178);
            this.Level2Passed.TabIndex = 7;
            this.Level2Passed.TabStop = false;
            // 
            // Level3Passed
            // 
            this.Level3Passed.BackColor = System.Drawing.Color.Transparent;
            this.Level3Passed.BackgroundImage = global::Jumping_Man.GameResources.Level_Passed_IMG;
            this.Level3Passed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level3Passed.Location = new System.Drawing.Point(1075, 607);
            this.Level3Passed.Name = "Level3Passed";
            this.Level3Passed.Size = new System.Drawing.Size(184, 178);
            this.Level3Passed.TabIndex = 8;
            this.Level3Passed.TabStop = false;
            // 
            // LevelsScreenTimer
            // 
            this.LevelsScreenTimer.Enabled = true;
            this.LevelsScreenTimer.Interval = 500;
            this.LevelsScreenTimer.Tick += new System.EventHandler(this.LevelsScreenTimer_Tick);
            // 
            // LevelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jumping_Man.GameResources.Level1Background1920x1080;
            this.Controls.Add(this.Level3Passed);
            this.Controls.Add(this.Level2Passed);
            this.Controls.Add(this.Level1Passed);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Level3Button);
            this.Controls.Add(this.Level2Button);
            this.Controls.Add(this.Level1Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LevelScreen";
            this.Size = new System.Drawing.Size(1502, 913);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level1Passed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level2Passed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level3Passed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Level1Button;
        private PictureBox Level2Button;
        private PictureBox Level3Button;
        private PictureBox BackButton;
        private PictureBox Level1Passed;
        private PictureBox Level2Passed;
        private PictureBox Level3Passed;
        private System.Windows.Forms.Timer LevelsScreenTimer;
    }
}
