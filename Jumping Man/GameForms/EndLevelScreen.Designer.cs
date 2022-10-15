namespace Jumping_Man.GameForms
{
    partial class EndLevelScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndLevelScreen));
            this.DeathLabel = new System.Windows.Forms.PictureBox();
            this.MainMenuButton = new System.Windows.Forms.PictureBox();
            this.levelStar1 = new Jumping_Man.GameForms.LevelStar();
            this.levelStar3 = new Jumping_Man.GameForms.LevelStar();
            this.levelStar2 = new Jumping_Man.GameForms.LevelStar();
            this.WinLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeathLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // DeathLabel
            // 
            this.DeathLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeathLabel.BackgroundImage = global::Jumping_Man.GameResources.DeathLabel;
            this.DeathLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeathLabel.Location = new System.Drawing.Point(621, 126);
            this.DeathLabel.Name = "DeathLabel";
            this.DeathLabel.Size = new System.Drawing.Size(284, 262);
            this.DeathLabel.TabIndex = 0;
            this.DeathLabel.TabStop = false;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuButton.BackgroundImage = global::Jumping_Man.GameResources.MainMenuLabel;
            this.MainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuButton.Location = new System.Drawing.Point(430, 544);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(667, 175);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.TabStop = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // levelStar1
            // 
            this.levelStar1.BackColor = System.Drawing.Color.Transparent;
            this.levelStar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelStar1.BackgroundImage")));
            this.levelStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelStar1.Location = new System.Drawing.Point(430, 230);
            this.levelStar1.Name = "levelStar1";
            this.levelStar1.Size = new System.Drawing.Size(172, 158);
            this.levelStar1.TabIndex = 2;
            // 
            // levelStar3
            // 
            this.levelStar3.BackColor = System.Drawing.Color.Transparent;
            this.levelStar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelStar3.BackgroundImage")));
            this.levelStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelStar3.Location = new System.Drawing.Point(925, 230);
            this.levelStar3.Name = "levelStar3";
            this.levelStar3.Size = new System.Drawing.Size(172, 158);
            this.levelStar3.TabIndex = 3;
            // 
            // levelStar2
            // 
            this.levelStar2.BackColor = System.Drawing.Color.Transparent;
            this.levelStar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelStar2.BackgroundImage")));
            this.levelStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelStar2.Location = new System.Drawing.Point(678, 230);
            this.levelStar2.Name = "levelStar2";
            this.levelStar2.Size = new System.Drawing.Size(172, 158);
            this.levelStar2.TabIndex = 4;
            // 
            // WinLabel
            // 
            this.WinLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinLabel.BackgroundImage = global::Jumping_Man.GameResources.Level_Passed_IMG;
            this.WinLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WinLabel.Location = new System.Drawing.Point(678, 26);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(172, 158);
            this.WinLabel.TabIndex = 5;
            this.WinLabel.TabStop = false;
            // 
            // EndLevelScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.WinLabel);
            this.Controls.Add(this.levelStar2);
            this.Controls.Add(this.levelStar3);
            this.Controls.Add(this.levelStar1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.DeathLabel);
            this.Name = "EndLevelScreen";
            this.Size = new System.Drawing.Size(1502, 913);
            ((System.ComponentModel.ISupportInitialize)(this.DeathLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox DeathLabel;
        private PictureBox MainMenuButton;
        private LevelStar levelStar1;
        private LevelStar levelStar3;
        private LevelStar levelStar2;
        private PictureBox WinLabel;
    }
}
