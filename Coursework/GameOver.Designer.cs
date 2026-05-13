
namespace Coursework
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.backToMM = new System.Windows.Forms.Button();
            this.replay = new System.Windows.Forms.Button();
            this.timeSpent = new System.Windows.Forms.TextBox();
            this.TotalScore = new System.Windows.Forms.TextBox();
            this.winBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMM
            // 
            this.backToMM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backToMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMM.Image = ((System.Drawing.Image)(resources.GetObject("backToMM.Image")));
            this.backToMM.Location = new System.Drawing.Point(942, 646);
            this.backToMM.Name = "backToMM";
            this.backToMM.Size = new System.Drawing.Size(376, 52);
            this.backToMM.TabIndex = 0;
            this.backToMM.UseVisualStyleBackColor = true;
            this.backToMM.Click += new System.EventHandler(this.backToMM_Click);
            // 
            // replay
            // 
            this.replay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay.Image = ((System.Drawing.Image)(resources.GetObject("replay.Image")));
            this.replay.Location = new System.Drawing.Point(150, 646);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(248, 61);
            this.replay.TabIndex = 1;
            this.replay.UseVisualStyleBackColor = true;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // timeSpent
            // 
            this.timeSpent.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.timeSpent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpent.ForeColor = System.Drawing.Color.Gold;
            this.timeSpent.Location = new System.Drawing.Point(262, 266);
            this.timeSpent.Multiline = true;
            this.timeSpent.Name = "timeSpent";
            this.timeSpent.Size = new System.Drawing.Size(100, 28);
            this.timeSpent.TabIndex = 2;
            // 
            // TotalScore
            // 
            this.TotalScore.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TotalScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScore.ForeColor = System.Drawing.Color.Gold;
            this.TotalScore.Location = new System.Drawing.Point(262, 388);
            this.TotalScore.Multiline = true;
            this.TotalScore.Name = "TotalScore";
            this.TotalScore.Size = new System.Drawing.Size(100, 28);
            this.TotalScore.TabIndex = 3;
            // 
            // winBox
            // 
            this.winBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winBox.BackgroundImage")));
            this.winBox.Location = new System.Drawing.Point(358, 46);
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(676, 154);
            this.winBox.TabIndex = 4;
            this.winBox.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1379, 785);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.TotalScore);
            this.Controls.Add(this.timeSpent);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.backToMM);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.winBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToMM;
        private System.Windows.Forms.Button replay;
        private System.Windows.Forms.TextBox timeSpent;
        private System.Windows.Forms.TextBox TotalScore;
        private System.Windows.Forms.PictureBox winBox;
    }
}