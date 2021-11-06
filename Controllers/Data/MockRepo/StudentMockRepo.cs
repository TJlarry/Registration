using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.MockRepo
{
    public class StudentMockRepo : IStudentRepo

    {

        private static List<StudentDto> _student = new List<StudentDto> {
            new StudentDto {S_studentId = 5634, S_firstName= "Bass",  S_lastName="Cuppy", S_EmailAddress="Bass.Cuppy@gmail.com",   S_phoneNumber="20497845755"},
            new StudentDto {S_studentId = 6790, S_firstName= "Peter", S_lastName="Jones", S_EmailAddress="Peter.Jones@gmail.com",  S_phoneNumber="63669036034"},
            new StudentDto {S_studentId = 3578, S_firstName= "Tayo",  S_lastName="Gbemi", S_EmailAddress="Tayo.Gbemi@gmail.com",   S_phoneNumber="64758502002"},
            new StudentDto {S_studentId = 5989, S_firstName= "Brandy",S_lastName="Brown", S_EmailAddress="Brandy.Brown@gmail.com", S_phoneNumber="67973752652"},
            new StudentDto {S_studentId = 0124, S_firstName= "kolo",  S_lastName="Beny",  S_EmailAddress="KoloBenny@gmail.com",    S_phoneNumber="08598658635"},
            new StudentDto {S_studentId = 6667, S_firstName= "Temi",  S_lastName="Reed",  S_EmailAddress="temiReed@gmail.com",     S_phoneNumber="08552785953"},
        };
        public void CreateStudent(StudentDto value)
        {
            int newId = _student.Max(k => k.S_studentId) + 1;
            value.S_studentId = newId;
            _student.Add(value); 
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDto> GetAllStudent()
        {
            return _student;
        }

        public StudentDto GetStudent(int id)
        {
            return _student.Where(y => y.S_studentId == id).FirstOrDefault();
        }

        public void UpdateStudent(StudentDto value)
        {
            throw new NotImplementedException();
        }
    }
}
