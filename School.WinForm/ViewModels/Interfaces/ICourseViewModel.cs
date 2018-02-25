using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities;

namespace School.WinForm.ViewModels.Interfaces
{
    public interface ICourseViewModel
    {
        List<Course> GetAllCourses();
        List<Department> GetDepartments();
        bool AddCourse(Course course);
        bool UpdateCourse(Course course);
    }    
}
