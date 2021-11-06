using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models.ModelsDto
{
    public class InstructorDto
    {
        [DisplayName("Indentification  Number")]
        public  string I_instructorID { get; set; }
        [DisplayName("First Name")]
        public string I_firstName { get; set; }
        [DisplayName("Last Name")]
        public string I_lastName { get; set; }
        [DisplayName(" Email Address")]
        public  string I_emailAddress { get; set; }
        [DisplayName(" Course Identification")]
        public int C_courseID { get; set; }


       

    }
}
