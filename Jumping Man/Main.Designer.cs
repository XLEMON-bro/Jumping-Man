namespace Jumping_Man
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGamePanel = new System.Windows.Forms.Panel();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MainGamePanel
            // 
            this.MainGamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGamePanel.Location = new System.Drawing.Point(0, 0);
            this.MainGamePanel.Name = "MainGamePanel";
            this.MainGamePanel.Size = new System.Drawing.Size(1502, 913);
            this.MainGamePanel.TabIndex = 0;
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Enabled = true;
            this.MainFormTimer.Interval = 200;
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 913);
            this.Controls.Add(this.MainGamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Jumping ... Man?";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainGamePanel;
        private System.Windows.Forms.Timer MainFormTimer;
    }
}