using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.MockRepo
{
    public class CourseMockRepo : ICourseRepo

    {

        private static List<CourseDto> _Course = new List<CourseDto>
        {
            new CourseDto { C_courseID = 1, C_courseNumber= "64745",  C_courseName="Database",           C_courseDescription=" DataBase management for beginners"},
            new CourseDto { C_courseID = 2, C_courseNumber= "64746",  C_courseName="Java Programming",   C_courseDescription="Intoduction to Object Oreineted Programming "},
            new CourseDto { C_courseID = 3, C_courseNumber= "64747",  C_courseName="C# programming",     C_courseDescription="Introduction to .NET in C# programming"},
            new CourseDto { C_courseID = 4, C_courseNumber = "64748", C_courseName = "Basic IT",         C_courseDescription = " Basic course on Information Tectnology" },
            new CourseDto { C_courseID = 5, C_courseNumber = "64749", C_courseName = "Software Testing", C_courseDescription = "Basic software testing tool for beginners" },
            new CourseDto { C_courseID = 6, C_courseNumber = "64750", C_courseName = " HTML5",           C_courseDescription = "HTML5 for begginners" },
        };
        public void CreateCourse(CourseDto value)
        {
            int newId = _Course.Max(x => x.C_courseID) + 1;
            value.C_courseID = newId;

            _Course.Add(value);
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseDto> GetAllCourses()
        {
            return _Course;
        }

        public CourseDto GetCourse(int id)
        {
            return _Course.Where(v => v.C_courseID == id).FirstOrDefault();
        }

        public void UpdateCourse(CourseDto value)
        {
            throw new NotImplementedException();
        }
    }
}
