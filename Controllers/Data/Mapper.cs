using CourseRegistration.Models;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data
{
    public class Mapper
    {
        public Course Map(CourseDto input)
        {
            return new Course
            {
                C_courseID = input.C_courseID,
                C_courseNumber = input.C_courseNumber,
                C_courseName = input.C_courseName,
                C_courseDescription = input.C_courseDescription,

            };

        }
        public CourseDto Map(Course input)
        {
            return new CourseDto
            {
                C_courseID = input.C_courseID,
                C_courseNumber = input.C_courseNumber,
                C_courseName = input.C_courseName,
                C_courseDescription = input.C_courseDescription,
            };
        }
        public Instructor Map(InstructorDto input)
        {
            return new Instructor
            {
               I_instructorID=input.I_instructorID,
               I_firstName =input.I_firstName,
               I_lastName=input.I_lastName,
               I_emailAddress=input.I_emailAddress,
               C_courseID= input.C_courseID,
            };
        }
        public InstructorDto Map(Instructor input)
        {
            return new InstructorDto
            {
                I_instructorID = input.I_instructorID,
                I_firstName = input.I_firstName,
                I_lastName = input.I_lastName,
                I_emailAddress = input.I_emailAddress,
                C_courseID =input.C_courseID,
            };
        }

        public Student  Map(StudentDto input)
        {
            return new Student
            {
                S_studentId = input.S_studentId,
                S_firstName = input.S_firstName,
                S_lastName = input.S_lastName,
                S_EmailAddress = input.S_EmailAddress,
                S_phoneNumber = input.S_phoneNumber,
            };    
        }
        public StudentDto Map(Student input)
        {
            return new StudentDto
            {
                S_studentId = input.S_studentId,
                S_firstName = input.S_firstName,
                S_lastName = input.S_lastName,
                S_EmailAddress = input.S_EmailAddress,
                S_phoneNumber = input.S_phoneNumber,
            };
        }
       
    }
}
