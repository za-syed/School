namespace School.WinForm.Views.CourseViews
{
    partial class CourseCreate
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
            this.PnlCourseUserControl = new System.Windows.Forms.Panel();
            this.ucCourse = new School.WinForm.Views.UserControls.CourseUserControl();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.PnlCourseUserControl.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCourseUserControl
            // 
            this.PnlCourseUserControl.Controls.Add(this.ucCourse);
            this.PnlCourseUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCourseUserControl.Location = new System.Drawing.Point(0, 0);
            this.PnlCourseUserControl.Name = "PnlCourseUserControl";
            this.PnlCourseUserControl.Size = new System.Drawing.Size(411, 118);
            this.PnlCourseUserControl.TabIndex = 0;
            // 
            // ucCourse
            // 
            this.ucCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCourse.Location = new System.Drawing.Point(0, 0);
            this.ucCourse.Name = "ucCourse";
            this.ucCourse.Size = new System.Drawing.Size(411, 118);
            this.ucCourse.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 118);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(411, 29);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(75, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CourseCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 143);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.PnlCourseUserControl);
            this.Name = "CourseCreate";
            this.Text = "CourseCreate";
            this.PnlCourseUserControl.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlCourseUserControl;
        public UserControls.CourseUserControl ucCourse;
        public System.Windows.Forms.Panel pnlButtons;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
    }
}