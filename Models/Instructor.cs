using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Instructor
    {
       [Key]
        public string I_instructorID { get; set; }       
        public string I_firstName { get; set; }     
        public string I_lastName { get; set; }      
        public string I_emailAddress { get; set; }
        [ForeignKey("Course")]
        public int? C_courseID { get; set; }
        public Course Course { get; set; }
    }
}
