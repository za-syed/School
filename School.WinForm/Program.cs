using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using School.Business.Implementations;
using School.Business.Interfaces;
using School.DataAccess.Implementations;
using School.DataAccess.Interfaces;
using School.WinForm.ViewModels.Implementations;
using School.WinForm.ViewModels.Interfaces;
using School.WinForm.Views.CourseViews;
using StructureMap;
using StructureMap.Attributes;

namespace School.WinForm
{
    static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ICourseDataAccess courseDataAccess = new CourseDataAccess();
            ICourseBusiness courseBusiness = new CourseBusiness(courseDataAccess);

            IDepartmentDataAccess departmentDataAccess = new DepartmentDataAccess();
            IDepartmentBusiness departmentBusiness = new DepartmentBusiness(departmentDataAccess);
            ICourseViewModel courseViewModel = new CourseViewModel(courseBusiness, departmentBusiness);
            Application.Run(new CourseRead(courseViewModel));
        }       
    }
}
