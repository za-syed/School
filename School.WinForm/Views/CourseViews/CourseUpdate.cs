using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Entities;
using School.WinForm.ViewModels.Interfaces;

namespace School.WinForm.Views.CourseViews
{
    public partial class CourseUpdate : Form
    {
        private ICourseViewModel _courseViewModel;
        private Course courseToBeUpdated;
        public bool Success { get; set; }
        public CourseUpdate(ICourseViewModel courseViewModel,Course course)
        {
            InitializeComponent();
            _courseViewModel = courseViewModel;
            courseToBeUpdated = course;
            InitializeCourseUserControl();
        }

        private void InitializeCourseUserControl()
        {
            ucCourse.txtID.Text = courseToBeUpdated.ID.ToString();
            ucCourse.txtCourseNumber.Text = courseToBeUpdated.CourseNumber;
            ucCourse.txtCourseName.Text = courseToBeUpdated.CourseName;
            ucCourse.txtCourseDescription.Text = courseToBeUpdated.CourseDescription;
            ucCourse.cboCredits.Text = courseToBeUpdated.Credits.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            courseToBeUpdated.CourseNumber = ucCourse.txtCourseNumber.Text;
            courseToBeUpdated.CourseName = ucCourse.txtCourseName.Text;
            courseToBeUpdated.CourseDescription = ucCourse.txtCourseDescription.Text;
            courseToBeUpdated.Credits = Convert.ToInt32(ucCourse.cboCredits.Text);
            Success = _courseViewModel.UpdateCourse(courseToBeUpdated);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
