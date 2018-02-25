namespace School.WinForm.Views.CourseViews
{
    partial class CourseRead
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCoursesGrid = new System.Windows.Forms.Panel();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlCoursesGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCourseNumber,
            this.colCourseName,
            this.colCourseDescription,
            this.colCredits,
            this.colDepartment,
            this.ColEdit,
            this.colDelete});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCourses.Location = new System.Drawing.Point(0, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowTemplate.Height = 24;
            this.dgvCourses.Size = new System.Drawing.Size(1248, 607);
            this.dgvCourses.TabIndex = 0;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1248, 42);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Courses";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlCoursesGrid
            // 
            this.pnlCoursesGrid.Controls.Add(this.dgvCourses);
            this.pnlCoursesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCoursesGrid.Location = new System.Drawing.Point(0, 42);
            this.pnlCoursesGrid.Name = "pnlCoursesGrid";
            this.pnlCoursesGrid.Size = new System.Drawing.Size(1248, 607);
            this.pnlCoursesGrid.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colCourseNumber
            // 
            this.colCourseNumber.HeaderText = "Course Number";
            this.colCourseNumber.Name = "colCourseNumber";
            this.colCourseNumber.ReadOnly = true;
            this.colCourseNumber.Width = 150;
            // 
            // colCourseName
            // 
            this.colCourseName.HeaderText = "Course Name";
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.ReadOnly = true;
            this.colCourseName.Width = 150;
            // 
            // colCourseDescription
            // 
            this.colCourseDescription.HeaderText = "Course Description";
            this.colCourseDescription.Name = "colCourseDescription";
            this.colCourseDescription.ReadOnly = true;
            this.colCourseDescription.Width = 250;
            // 
            // colCredits
            // 
            this.colCredits.HeaderText = "Credits";
            this.colCredits.Name = "colCredits";
            this.colCredits.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Width = 150;
            // 
            // ColEdit
            // 
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // CourseRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 649);
            this.Controls.Add(this.pnlCoursesGrid);
            this.Controls.Add(this.pnlButtons);
            this.Name = "CourseRead";
            this.Text = "Course Read";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCoursesGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlCoursesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}