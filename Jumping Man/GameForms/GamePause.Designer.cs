namespace Jumping_Man.GameForms
{
    partial class GamePause
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
            this.MainMenuButton = new System.Windows.Forms.PictureBox();
            this.BacktoGameButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoGameButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MainMenuButton.BackgroundImage = global::Jumping_Man.GameResources.MainMenuLabel;
            this.MainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuButton.Location = new System.Drawing.Point(411, 145);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(667, 175);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.TabStop = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // BacktoGameButton
            // 
            this.BacktoGameButton.BackColor = System.Drawing.Color.Transparent;
            this.BacktoGameButton.BackgroundImage = global::Jumping_Man.GameResources.BackLabelIMG;
            this.BacktoGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BacktoGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacktoGameButton.Location = new System.Drawing.Point(527, 467);
            this.BacktoGameButton.Name = "BacktoGameButton";
            this.BacktoGameButton.Size = new System.Drawing.Size(452, 175);
            this.BacktoGameButton.TabIndex = 1;
            this.BacktoGameButton.TabStop = false;
            this.BacktoGameButton.Click += new System.EventHandler(this.BacktoGameButton_Click);
            // 
            // GamePause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BacktoGameButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "GamePause";
            this.Size = new System.Drawing.Size(1502, 913);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoGameButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox MainMenuButton;
        private PictureBox BacktoGameButton;
    }
}
