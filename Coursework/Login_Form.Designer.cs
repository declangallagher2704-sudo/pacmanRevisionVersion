
namespace Coursework
{
    partial class LoginMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
            this.LoginBTN = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            this.UserTXT = new System.Windows.Forms.TextBox();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoginBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBTN.BackgroundImage")));
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginBTN.FlatAppearance.BorderSize = 0;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Location = new System.Drawing.Point(237, 328);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(509, 58);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.TabStop = false;
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterBTN.BackgroundImage")));
            this.RegisterBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBTN.Location = new System.Drawing.Point(237, 402);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(509, 58);
            this.RegisterBTN.TabIndex = 1;
            this.RegisterBTN.Click += new System.EventHandler(this.RegisterBTN_Click);
            // 
            // UserTXT
            // 
            this.UserTXT.Location = new System.Drawing.Point(517, 195);
            this.UserTXT.Name = "UserTXT";
            this.UserTXT.Size = new System.Drawing.Size(200, 20);
            this.UserTXT.TabIndex = 2;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(517, 268);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(200, 20);
            this.PasswordTXT.TabIndex = 3;
            this.PasswordTXT.UseSystemPasswordChar = true;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 649);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.UserTXT);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.LoginBTN);
            this.DoubleBuffered = true;
            this.Name = "LoginMenu";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox UserTXT;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button RegisterBTN;
    }
}

