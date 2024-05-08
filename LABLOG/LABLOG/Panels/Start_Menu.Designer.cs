namespace LABLOG.Panels
{
    partial class Start_Menu
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
            this.Manage_btn = new System.Windows.Forms.Button();
            this.Logbook_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimeShower = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Manage_btn
            // 
            this.Manage_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manage_btn.BackColor = System.Drawing.Color.White;
            this.Manage_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Manage_btn.FlatAppearance.BorderSize = 0;
            this.Manage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Manage_btn.ForeColor = System.Drawing.Color.Black;
            this.Manage_btn.Image = global::LABLOG.Properties.Resources.Settings_Logo;
            this.Manage_btn.Location = new System.Drawing.Point(410, 604);
            this.Manage_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manage_btn.Name = "Manage_btn";
            this.Manage_btn.Size = new System.Drawing.Size(144, 49);
            this.Manage_btn.TabIndex = 1;
            this.Manage_btn.Text = "MANAGE";
            this.Manage_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Manage_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Manage_btn.UseVisualStyleBackColor = false;
            this.Manage_btn.Click += new System.EventHandler(this.Manage_btn_Click);
            // 
            // Logbook_btn
            // 
            this.Logbook_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logbook_btn.BackColor = System.Drawing.Color.White;
            this.Logbook_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Logbook_btn.FlatAppearance.BorderSize = 0;
            this.Logbook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logbook_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbook_btn.ForeColor = System.Drawing.Color.Black;
            this.Logbook_btn.Image = global::LABLOG.Properties.Resources.Person_Logo;
            this.Logbook_btn.Location = new System.Drawing.Point(393, 506);
            this.Logbook_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logbook_btn.Name = "Logbook_btn";
            this.Logbook_btn.Size = new System.Drawing.Size(178, 60);
            this.Logbook_btn.TabIndex = 4;
            this.Logbook_btn.Text = "TIME-IN";
            this.Logbook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logbook_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logbook_btn.UseVisualStyleBackColor = false;
            this.Logbook_btn.Click += new System.EventHandler(this.Logbook_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LABLOG.Properties.Resources.LabLog_Header;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(215, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 212);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TimeShower
            // 
            this.TimeShower.AutoSize = true;
            this.TimeShower.BackColor = System.Drawing.Color.Transparent;
            this.TimeShower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeShower.ForeColor = System.Drawing.Color.White;
            this.TimeShower.Location = new System.Drawing.Point(18, 14);
            this.TimeShower.Name = "TimeShower";
            this.TimeShower.Size = new System.Drawing.Size(48, 29);
            this.TimeShower.TabIndex = 6;
            this.TimeShower.Text = ". . .";
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::LABLOG.Properties.Resources.Introduction_Wallaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TimeShower);
            this.Controls.Add(this.Manage_btn);
            this.Controls.Add(this.Logbook_btn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Start_Menu";
            this.Size = new System.Drawing.Size(945, 712);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Manage_btn;
        private System.Windows.Forms.Button Logbook_btn;
        private System.Windows.Forms.Label TimeShower;
    }
}
