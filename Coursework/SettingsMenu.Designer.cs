
namespace Coursework
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.back = new System.Windows.Forms.Button();
            this.openControls = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(413, 529);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 44);
            this.back.TabIndex = 0;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // openControls
            // 
            this.openControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openControls.Image = ((System.Drawing.Image)(resources.GetObject("openControls.Image")));
            this.openControls.Location = new System.Drawing.Point(387, 242);
            this.openControls.Name = "openControls";
            this.openControls.Size = new System.Drawing.Size(172, 49);
            this.openControls.TabIndex = 1;
            this.openControls.UseVisualStyleBackColor = true;
            this.openControls.Click += new System.EventHandler(this.openControls_Click);
            // 
            // mute
            // 
            this.mute.Image = global::Coursework.Properties.Resources.mutedIcon;
            this.mute.Location = new System.Drawing.Point(439, 409);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(50, 50);
            this.mute.TabIndex = 3;
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.volumeBar.Location = new System.Drawing.Point(278, 327);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(391, 45);
            this.volumeBar.TabIndex = 5;
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 654);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.openControls);
            this.Controls.Add(this.back);
            this.Name = "SettingsMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button openControls;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.TrackBar volumeBar;
    }
}