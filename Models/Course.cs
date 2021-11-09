using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Course
    {
       [Key]
        public int C_courseID { get; set; }
       
        public string C_courseNumber { get; set; }
       
        public string C_courseName { get; set; }
   
        public string C_courseDescription { get; set; }
    }
}
