using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Entities;

namespace School.WinForm.Views.UserControls
{
    public partial class CourseUserControl : UserControl
    {
        public CourseUserControl()
        {
            InitializeComponent();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department dept = (Department)cboDepartment.SelectedItem;
            txtCourseNumber.Text = dept.DepartmentCode;
        }
    }
}
