using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.SqlRepo
{
    public class StudentSqlRepo : IStudentRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public StudentSqlRepo(AppDbContext context)
        {
            _context = context;

        }
        public void CreateStudent(StudentDto value)
        {
            Student addItem = _mapper.Map(value);
            _context.Students.Add(addItem);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDto> GetAllStudent()
        {
                   return _context.Students
                 .Select(v => _mapper.Map(v))
                 .ToList();
        }

        public StudentDto GetStudent(int id)
        {
            Student  gtStudent = _context.Students.FirstOrDefault(x => x.S_studentId == id);
            if (gtStudent != null)
            {
                return _mapper.Map(gtStudent);

            }
                return null;
        }

        public void UpdateStudent(StudentDto value)
        {
            var toUpdateStudent =
                _context.Students.FirstOrDefault(x=> x.S_studentId == value.S_studentId);
            if (toUpdateStudent != null)
            {
                toUpdateStudent.S_firstName = value.S_firstName;
                toUpdateStudent.S_lastName = value.S_lastName;
                toUpdateStudent.S_EmailAddress = value.S_EmailAddress;
                toUpdateStudent.S_phoneNumber = value.S_phoneNumber;

            }
            _context.SaveChanges();
        }
    }
}
