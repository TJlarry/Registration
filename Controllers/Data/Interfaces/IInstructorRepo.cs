using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.Interfaces
{
    public interface IInstructorRepo
    {
        void CreateInstructor(InstructorDto value); // create
        IEnumerable<InstructorDto> GetAllInstructor();// read all instructor
        InstructorDto GetInstructor(int id);
        void UpdateInstructor(InstructorDto value); // update instructor
        void DeleteInstructor(int id);// delete instructor





    }
}
