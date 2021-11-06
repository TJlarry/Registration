using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.Interfaces
{
    public interface IStudentRepo
    {
        void CreateStudent(StudentDto value); // create student
        IEnumerable<StudentDto> GetAllStudent();// read all student
        StudentDto GetStudent(int id);
        void UpdateStudent(StudentDto value); // update student
        void DeleteStudent(int id);// delete student

    }
}
