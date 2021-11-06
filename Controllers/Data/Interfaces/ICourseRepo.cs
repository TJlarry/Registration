using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.Interfaces
{
    public interface ICourseRepo
    {
        void CreateCourse(CourseDto value); // create
        IEnumerable<CourseDto> GetAllCourses();// read all course
        CourseDto GetCourse(int id);
        void UpdateCourse(CourseDto value); // update courses
        void DeleteCourse(int id);// delete courses
    }
}
