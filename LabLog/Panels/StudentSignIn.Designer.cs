namespace LabLog.Panels
{
    partial class StudentSignIn
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.WhosLogin = new System.Windows.Forms.ComboBox();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 790);
            this.panel1.TabIndex = 0;
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
            this.ReturnButton.Location = new System.Drawing.Point(24, 20);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(115, 39);
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
            this.pictureBox1.Location = new System.Drawing.Point(8, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 182);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(651, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 641);
            this.panel2.TabIndex = 19;
            // 
            // WhosLogin
            // 
            this.WhosLogin.BackColor = System.Drawing.Color.White;
            this.WhosLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhosLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhosLogin.FormattingEnabled = true;
            this.WhosLogin.Items.AddRange(new object[] {
            "Staff",
            "Student",
            "Others"});
            this.WhosLogin.Location = new System.Drawing.Point(523, 26);
            this.WhosLogin.Margin = new System.Windows.Forms.Padding(4);
            this.WhosLogin.Name = "WhosLogin";
            this.WhosLogin.Size = new System.Drawing.Size(140, 33);
            this.WhosLogin.TabIndex = 22;
            this.WhosLogin.SelectedIndexChanged += new System.EventHandler(this.WhosLogin_SelectedIndexChanged);
            // 
            // StudentSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.WhosLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentSignIn";
            this.Size = new System.Drawing.Size(1316, 782);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox WhosLogin;
    }
}
