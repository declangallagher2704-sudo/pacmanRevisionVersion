
namespace Coursework
{
    partial class controlsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlsScreen));
            this.newLeftControl = new System.Windows.Forms.TextBox();
            this.newRightControl = new System.Windows.Forms.TextBox();
            this.newUpControl = new System.Windows.Forms.TextBox();
            this.newDownControl = new System.Windows.Forms.TextBox();
            this.backToSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newLeftControl
            // 
            this.newLeftControl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newLeftControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newLeftControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.newLeftControl.ForeColor = System.Drawing.Color.Gold;
            this.newLeftControl.Location = new System.Drawing.Point(457, 160);
            this.newLeftControl.MaxLength = 1;
            this.newLeftControl.Name = "newLeftControl";
            this.newLeftControl.Size = new System.Drawing.Size(155, 20);
            this.newLeftControl.TabIndex = 4;
            this.newLeftControl.TextChanged += new System.EventHandler(this.newLeftControl_TextChanged);
            // 
            // newRightControl
            // 
            this.newRightControl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newRightControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newRightControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.newRightControl.ForeColor = System.Drawing.Color.Gold;
            this.newRightControl.Location = new System.Drawing.Point(457, 218);
            this.newRightControl.MaxLength = 1;
            this.newRightControl.Name = "newRightControl";
            this.newRightControl.Size = new System.Drawing.Size(155, 20);
            this.newRightControl.TabIndex = 5;
            this.newRightControl.TextChanged += new System.EventHandler(this.newRightControl_TextChanged);
            // 
            // newUpControl
            // 
            this.newUpControl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newUpControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUpControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.newUpControl.ForeColor = System.Drawing.Color.Gold;
            this.newUpControl.Location = new System.Drawing.Point(457, 282);
            this.newUpControl.MaxLength = 1;
            this.newUpControl.Name = "newUpControl";
            this.newUpControl.Size = new System.Drawing.Size(155, 20);
            this.newUpControl.TabIndex = 6;
            this.newUpControl.TextChanged += new System.EventHandler(this.newUpControl_TextChanged);
            // 
            // newDownControl
            // 
            this.newDownControl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newDownControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newDownControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.newDownControl.ForeColor = System.Drawing.Color.Gold;
            this.newDownControl.Location = new System.Drawing.Point(457, 345);
            this.newDownControl.MaxLength = 1;
            this.newDownControl.Name = "newDownControl";
            this.newDownControl.Size = new System.Drawing.Size(155, 20);
            this.newDownControl.TabIndex = 7;
            this.newDownControl.TextChanged += new System.EventHandler(this.newDownControl_TextChanged);
            // 
            // backToSettings
            // 
            this.backToSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToSettings.Image = ((System.Drawing.Image)(resources.GetObject("backToSettings.Image")));
            this.backToSettings.Location = new System.Drawing.Point(299, 498);
            this.backToSettings.Name = "backToSettings";
            this.backToSettings.Size = new System.Drawing.Size(96, 47);
            this.backToSettings.TabIndex = 8;
            this.backToSettings.UseVisualStyleBackColor = true;
            this.backToSettings.Click += new System.EventHandler(this.backToSettings_Click);
            // 
            // controlsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(779, 576);
            this.Controls.Add(this.backToSettings);
            this.Controls.Add(this.newDownControl);
            this.Controls.Add(this.newUpControl);
            this.Controls.Add(this.newRightControl);
            this.Controls.Add(this.newLeftControl);
            this.Name = "controlsScreen";
            this.Text = "controls";
            this.Load += new System.EventHandler(this.controls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newLeftControl;
        private System.Windows.Forms.TextBox newRightControl;
        private System.Windows.Forms.TextBox newUpControl;
        private System.Windows.Forms.TextBox newDownControl;
        private System.Windows.Forms.Button backToSettings;
    }
}