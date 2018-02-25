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
using StructureMap.Attributes;

namespace School.WinForm.Views.CourseViews
{
    public partial class CourseRead : Form
    {
        private ICourseViewModel _courseViewModel;
        [SetterProperty]
        public  ICourseViewModel courseViewModel
        {
            set { _courseViewModel = value; }
        }
        public CourseRead()
        {
            InitializeComponent();
            LoadData();
        }
        public CourseRead(ICourseViewModel courseViewModel)
        {
            InitializeComponent();
            _courseViewModel = courseViewModel;
            LoadData();
        }
       

        private void LoadData()
        {
            dgvCourses.Rows.Clear();
            foreach (Course course in _courseViewModel.GetAllCourses())
            {
                dgvCourses.Rows.Add(course.ID, course.CourseNumber,
                    course.CourseName,course.CourseDescription,
                    course.Credits,course.Department.DepartmentDescription ,"Edit","Delete");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseCreate courseCreate = new CourseCreate(_courseViewModel);
            courseCreate.ShowDialog();
            if (courseCreate.Success)
                LoadData();

        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            Course course = new Course();
            DataGridViewRow row = dgvCourses.Rows[rowIndex];
            course.ID = Convert.ToInt32(row.Cells["colID"].Value.ToString());
            course.CourseNumber = row.Cells["colCourseNumber"].Value.ToString();
            course.CourseName = row.Cells["colCourseName"].Value.ToString();
            course.CourseDescription = row.Cells["colCourseDescription"].Value.ToString();
            course.Credits = Convert.ToInt32(row.Cells["colID"].Value.ToString());
            switch (columnIndex)
            {
                case 5:
                    CourseUpdate updateView = new CourseUpdate(_courseViewModel, course);
                    updateView.ShowDialog();
                    if (updateView.Success)
                        LoadData();
                    break;
                case 6:
                    break;
                default:
                    break;
            }            

        }
    }
}
