﻿namespace LabLog.Panels
{
    partial class InstructorSignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewPassword = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 642);
            this.panel1.TabIndex = 1;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Image = global::LabLog.Properties.Resources.Return_Logo_White;
            this.ReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnButton.Location = new System.Drawing.Point(18, 16);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(86, 32);
            this.ReturnButton.TabIndex = 21;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LabLog.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 142);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 170);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(421, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 55);
            this.label3.TabIndex = 22;
            this.label3.Text = "INSTRUCTORS LOGIN";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(591, 197);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(271, 29);
            this.Username.TabIndex = 24;
            this.Username.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(494, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Username:";
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(591, 233);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(271, 29);
            this.Password.TabIndex = 26;
            this.Password.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(494, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Password:";
            // 
            // ViewPassword
            // 
            this.ViewPassword.BackColor = System.Drawing.Color.Transparent;
            this.ViewPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.ViewPassword.FlatAppearance.BorderSize = 0;
            this.ViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPassword.ForeColor = System.Drawing.Color.Black;
            this.ViewPassword.Image = global::LabLog.Properties.Resources.View_Password_Logo;
            this.ViewPassword.Location = new System.Drawing.Point(867, 239);
            this.ViewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.ViewPassword.Name = "ViewPassword";
            this.ViewPassword.Size = new System.Drawing.Size(32, 23);
            this.ViewPassword.TabIndex = 0;
            this.ViewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewPassword.UseVisualStyleBackColor = false;
            this.ViewPassword.Click += new System.EventHandler(this.ViewPassword_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Image = global::LabLog.Properties.Resources.Person_Logo;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(637, 487);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(86, 32);
            this.LoginButton.TabIndex = 23;
            this.LoginButton.Text = "Log-In";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InstructorSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ViewPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "InstructorSignIn";
            this.Size = new System.Drawing.Size(987, 635);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewPassword;
    }
}
