using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.Models.ModelsDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.SqlRepo
{
    public class InstructorSqlRepo : IInstructorRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public  InstructorSqlRepo(AppDbContext context)
        {
            _context = context;

        }
        public void CreateInstructor(InstructorDto value)
        {

            Instructor addItem = _mapper.Map(value);
            _context.Instructors.Add(addItem);
            _context.SaveChanges();
        }

        public void DeleteInstructor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstructorDto>GetAllInstructor()
        {
            return _context.Instructors
                 .Select(z => _mapper.Map(z))
                 .ToList();
        }

        public InstructorDto GetInstructor(string id)
        {
 
            Instructor gtInstructor = _context.Instructors.FirstOrDefault(x => x.I_instructorID == id);
            if (gtInstructor != null)
            {
                return _mapper.Map(gtInstructor);

            }
            return null;
        }

        public void UpdateInstructor(InstructorDto value)
        {
            var toUpdateInstructor =
                _context.Instructors.FirstOrDefault(x => x.I_instructorID == value.I_instructorID);
            if (toUpdateInstructor != null)
            {
                toUpdateInstructor.I_firstName = value.I_firstName;
                toUpdateInstructor.I_lastName = value.I_lastName;
                toUpdateInstructor.I_emailAddress = value.I_emailAddress;
                

            }
            _context.SaveChanges();
        }
    }
}
