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

        private static List<CourseDto> _Courses = new List<CourseDto>
        {
            new CourseDto { C_courseID = 001, C_courseNumber= "64745",  C_courseName="Database",           C_courseDescription=" DataBase management for beginners"},
            new CourseDto { C_courseID = 002, C_courseNumber= "64746",  C_courseName="Java Programming",   C_courseDescription="Intoduction to Object Oreineted Programming "},
            new CourseDto { C_courseID = 003, C_courseNumber= "64747",  C_courseName="C# programming",     C_courseDescription="Introduction to .NET in C# programming"},
            new CourseDto { C_courseID = 004, C_courseNumber = "64748", C_courseName = "Basic IT",         C_courseDescription = " Basic course on Information Tectnology" },
            new CourseDto { C_courseID = 005, C_courseNumber = "64749", C_courseName = "Software Testing", C_courseDescription = "Basic software testing tool for beginners" },
            new CourseDto { C_courseID = 006, C_courseNumber = "64750", C_courseName = " HTML5",           C_courseDescription = "HTML5 for begginners" },
        };
        public void CreateCourse(CourseDto value)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseDto> GetAllCourses()
        {
            return _Courses;
        }

        public CourseDto GetCourse(int id)
        {
            return _Courses.Where(v => v.C_courseID == id).FirstOrDefault();
        }

        public void UpdateCourse(CourseDto value)
        {
            throw new NotImplementedException();
        }
    }
}
