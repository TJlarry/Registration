using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models.ModelsDto
{
    public class CourseDto
    {
        [DisplayName("Course Identification")]
        public int C_courseID { get; set; }
        [DisplayName("Course Number")]
        public string C_courseNumber { get; set; }
        [DisplayName("Course Name")]
        public string C_courseName { get; set; }
        [DisplayName("Course Description")]
        public string C_courseDescription { get; set; }
    }
}
