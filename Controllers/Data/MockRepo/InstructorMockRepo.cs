using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.MockRepo
{
  
    public class InstructorMockRepo : IInstructorRepo

    {
 private static List<InstructorDto> _Instructors = new List<InstructorDto>
    {
            new InstructorDto {I_instructorID = "7773",I_firstName= "James",   I_lastName="Bonjo",  I_emailAddress="james.B@gmail.com",  C_courseID=001},
            new InstructorDto {I_instructorID = "7734",I_firstName= "John",    I_lastName="Prince", I_emailAddress="john.P@gmail.com",   C_courseID=002},
            new InstructorDto {I_instructorID = "7373",I_firstName= "Beth",    I_lastName="Brand",  I_emailAddress="beth.B@gmail.com",   C_courseID=003},
            new InstructorDto {I_instructorID = "7883" ,I_firstName= "Mark",    I_lastName="Zoe",    I_emailAddress="Mark.z@gmail.com",   C_courseID=004},
            new InstructorDto {I_instructorID = "7353",I_firstName= "Zion",    I_lastName="Cain",   I_emailAddress="ZionC@gmail.com",    C_courseID=005},
            new InstructorDto {I_instructorID = "7233",I_firstName= "Heather", I_lastName="Yari",   I_emailAddress="HeatherY@gmail.com", C_courseID=006},

    };
        public void CreateInstructor(InstructorDto value)
        {
            string newId = _Instructors.Max(x => x.I_instructorID) + 1;
            value.I_instructorID = newId;

            _Instructors.Add(value);



        }

        public void DeleteInstructor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InstructorDto> GetAllInstructor()
        {
            return _Instructors;
        }

        public InstructorDto GetInstructor(string id)
        {
            return _Instructors.Where(x => x.I_instructorID== id).FirstOrDefault();
        }

        public void UpdateInstructor(InstructorDto value)
        {
            throw new NotImplementedException();
        }
    }
}
