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
    public partial class CourseCreate : Form
    {
        public bool Success { get; set; }
        private ICourseViewModel _courseViewModel;
        private List<Department> _departments = new List<Department>();
        public CourseCreate()
        {
            InitializeComponent();
        }
        public CourseCreate(ICourseViewModel courseViewModel)
        {
            _courseViewModel = courseViewModel;
            InitializeComponent();
            _departments = _courseViewModel.GetDepartments();
            _departments.Insert(0, new Department() {
                ID=0,
                DepartmentCode="",
                DepartmentDescription ="Please Select"
            });

            ucCourse.cboDepartment.DataSource = _departments;
            ucCourse.cboDepartment.DisplayMember = "DepartmentDescription";
            ucCourse.cboDepartment.ValueMember = "DepartmentCode";

            ucCourse.lblID.Hide();
            ucCourse.txtID.Hide();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Success = Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Save() {
            Course course = new Course();
            course.CourseNumber = ucCourse.txtCourseNumber.Text;
            course.CourseName = ucCourse.txtCourseName.Text;
            course.CourseDescription = ucCourse.txtCourseDescription.Text;
            course.Credits = Convert.ToInt32(ucCourse.cboCredits.Text);
            if (ucCourse.cboDepartment.SelectedIndex > 0)
            {
                //Using Lamda expression.
                //Department dept = _departments.Find(item => item.DepartmentCode == ucCourse.cboDepartment.SelectedValue.ToString());
                Department dept = ucCourse.cboDepartment.SelectedItem as Department;
                course.Department = dept;
            }
            return _courseViewModel.AddCourse(course);
        }
    }
}
