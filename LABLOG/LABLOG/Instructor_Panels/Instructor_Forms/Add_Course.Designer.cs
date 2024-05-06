namespace LABLOG.Instructor_Panels.Instructor_Forms
{
    partial class Add_Course
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.coursebox = new System.Windows.Forms.TextBox();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Statusbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.27233F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.72767F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.coursebox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.titlebox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Statusbox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 184);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Course:";
            // 
            // coursebox
            // 
            this.coursebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coursebox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebox.Location = new System.Drawing.Point(127, 15);
            this.coursebox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.coursebox.Name = "coursebox";
            this.coursebox.Size = new System.Drawing.Size(362, 30);
            this.coursebox.TabIndex = 41;
            // 
            // titlebox
            // 
            this.titlebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titlebox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(127, 76);
            this.titlebox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(362, 30);
            this.titlebox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Title:";
            // 
            // Statusbox
            // 
            this.Statusbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Statusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Statusbox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statusbox.FormattingEnabled = true;
            this.Statusbox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Statusbox.Location = new System.Drawing.Point(127, 137);
            this.Statusbox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Statusbox.Name = "Statusbox";
            this.Statusbox.Size = new System.Drawing.Size(139, 32);
            this.Statusbox.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Status:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(69, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 68);
            this.label7.TabIndex = 64;
            this.label7.Text = "Adding Course";
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(46)))), ((int)(((byte)(77)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Black;
            this.add_btn.Image = global::LABLOG.Properties.Resources.Add_Logo;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(250, 334);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(126, 39);
            this.add_btn.TabIndex = 63;
            this.add_btn.Text = "Add";
            this.add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LABLOG.Properties.Resources.Introduction_Wallaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Course";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coursebox;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Statusbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_btn;
    }
}