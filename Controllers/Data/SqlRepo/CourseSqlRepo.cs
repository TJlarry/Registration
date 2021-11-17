using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models;
using CourseRegistration.Models.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers.Data.SqlRepo
{
    
    public class CourseSqlRepo : ICourseRepo
    {
        private readonly AppDbContext _context;
        private readonly Mapper _mapper = new Mapper();

        public CourseSqlRepo(AppDbContext context) {

            _context = context;
        }
        public void CreateCourse(CourseDto value)
        {
            Course addItem = _mapper.Map(value);
            _context.Courses.Add(addItem);
            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseDto> GetAllCourses()
        {
           return _context.Courses
                .Select(v => _mapper.Map(v))
                .ToList();
             
        }

        public CourseDto GetCourse(int id)
        {
            Course gtCourse = _context.Courses.FirstOrDefault(v => v.C_courseID == id);
            if (gtCourse != null)
            {
                return _mapper.Map(gtCourse);

            }
            return null;

        }

        public void UpdateCourse(CourseDto value)
        {
            var toUpdateCourse = _context.Courses.FirstOrDefault(v => v.C_courseID == value.C_courseID);
            if (toUpdateCourse != null) {
                toUpdateCourse.C_courseNumber = value.C_courseNumber;
                toUpdateCourse.C_courseName = value.C_courseName;
               
                toUpdateCourse.C_courseDescription = value.C_courseDescription;
            }
             _context.SaveChanges();

        }
    }
}
