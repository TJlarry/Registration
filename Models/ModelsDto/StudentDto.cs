using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models.ModelsDto
{
    public class StudentDto
    {
        [DisplayName("Student Identification")]
         public int S_studentId { get; set; }
        [DisplayName("First Name")]
        public string S_firstName { get; set; }
        [DisplayName("Last Name")]
        public string S_lastName { get; set; }
        [DisplayName("Email Address")]
        public string S_EmailAddress { get; set; }
        [DisplayName(" Contact Number")]
        public string S_phoneNumber { get; set; }



    }
}
