
namespace Coursework
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.openGameControl = new System.Windows.Forms.Button();
            this.openSettings = new System.Windows.Forms.Button();
            this.closeApp = new System.Windows.Forms.Button();
            this.openLeaderboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openGameControl
            // 
            this.openGameControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openGameControl.BackgroundImage")));
            this.openGameControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGameControl.Location = new System.Drawing.Point(507, 207);
            this.openGameControl.Name = "openGameControl";
            this.openGameControl.Size = new System.Drawing.Size(324, 61);
            this.openGameControl.TabIndex = 3;
            this.openGameControl.UseVisualStyleBackColor = true;
            this.openGameControl.Click += new System.EventHandler(this.openGame_Click);
            // 
            // openSettings
            // 
            this.openSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openSettings.BackgroundImage")));
            this.openSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSettings.Location = new System.Drawing.Point(507, 316);
            this.openSettings.Name = "openSettings";
            this.openSettings.Size = new System.Drawing.Size(324, 61);
            this.openSettings.TabIndex = 4;
            this.openSettings.UseVisualStyleBackColor = true;
            this.openSettings.Click += new System.EventHandler(this.openSettings_Click);
            // 
            // closeApp
            // 
            this.closeApp.BackColor = System.Drawing.Color.Transparent;
            this.closeApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeApp.BackgroundImage")));
            this.closeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeApp.Location = new System.Drawing.Point(507, 533);
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(324, 61);
            this.closeApp.TabIndex = 5;
            this.closeApp.UseVisualStyleBackColor = false;
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // openLeaderboard
            // 
            this.openLeaderboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openLeaderboard.BackgroundImage")));
            this.openLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openLeaderboard.Location = new System.Drawing.Point(507, 423);
            this.openLeaderboard.Name = "openLeaderboard";
            this.openLeaderboard.Size = new System.Drawing.Size(324, 61);
            this.openLeaderboard.TabIndex = 6;
            this.openLeaderboard.UseVisualStyleBackColor = true;
            this.openLeaderboard.Click += new System.EventHandler(this.openLeaderboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(610, 701);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 102);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1422, 803);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openLeaderboard);
            this.Controls.Add(this.openSettings);
            this.Controls.Add(this.openGameControl);
            this.Controls.Add(this.closeApp);
            this.Name = "MainMenu";
            this.Text = "S";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openGameControl;
        private System.Windows.Forms.Button openSettings;
        private System.Windows.Forms.Button closeApp;
        private System.Windows.Forms.Button openLeaderboard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}