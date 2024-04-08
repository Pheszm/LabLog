namespace PracticeForSQL
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.StuNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuIDTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuCourseTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuYearLevelTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuGenderTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 38);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNameTable,
            this.StuIDTable,
            this.StuCourseTable,
            this.StuYearLevelTable,
            this.StuGenderTable});
            this.DataGrid.Location = new System.Drawing.Point(152, 10);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.ShowCellToolTips = false;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.Size = new System.Drawing.Size(475, 400);
            this.DataGrid.TabIndex = 15;
            // 
            // StuNameTable
            // 
            this.StuNameTable.HeaderText = "Name";
            this.StuNameTable.MinimumWidth = 6;
            this.StuNameTable.Name = "StuNameTable";
            this.StuNameTable.ReadOnly = true;
            // 
            // StuIDTable
            // 
            this.StuIDTable.HeaderText = "StudentID";
            this.StuIDTable.MinimumWidth = 6;
            this.StuIDTable.Name = "StuIDTable";
            this.StuIDTable.ReadOnly = true;
            // 
            // StuCourseTable
            // 
            this.StuCourseTable.HeaderText = "Course";
            this.StuCourseTable.MinimumWidth = 6;
            this.StuCourseTable.Name = "StuCourseTable";
            this.StuCourseTable.ReadOnly = true;
            // 
            // StuYearLevelTable
            // 
            this.StuYearLevelTable.HeaderText = "Year-Level";
            this.StuYearLevelTable.MinimumWidth = 6;
            this.StuYearLevelTable.Name = "StuYearLevelTable";
            this.StuYearLevelTable.ReadOnly = true;
            // 
            // StuGenderTable
            // 
            this.StuGenderTable.HeaderText = "Gender";
            this.StuGenderTable.MinimumWidth = 6;
            this.StuGenderTable.Name = "StuGenderTable";
            this.StuGenderTable.ReadOnly = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(647, 74);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 38);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(647, 128);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(125, 38);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNameTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuIDTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuCourseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuYearLevelTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuGenderTable;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
    }
}

