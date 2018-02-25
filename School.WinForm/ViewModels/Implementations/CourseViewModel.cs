using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Entities;
using School.Business.Interfaces;
using School.WinForm.ViewModels.Interfaces;


namespace School.WinForm.ViewModels.Implementations
{
    public class CourseViewModel: ICourseViewModel
    {
        private ICourseBusiness _courseBusiness;
        private IDepartmentBusiness _departmentBusiness;
        public CourseViewModel(ICourseBusiness courseBusiness,IDepartmentBusiness departmentBusiness)
        {
            _courseBusiness = courseBusiness;
            _departmentBusiness = departmentBusiness;
        }
        public List<Course> GetAllCourses() {
            return _courseBusiness.GetAllCourses();
        }
        public bool AddCourse(Course course) {
            return _courseBusiness.AddCourse(course);
        }
        public bool UpdateCourse(Course course)
        {
            return _courseBusiness.UpdateCourse(course);
        }

        public List<Department> GetDepartments()
        {
            return _departmentBusiness.GetDepartments();
        }
    }
}
