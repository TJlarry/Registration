using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class Student
    {
       [Key]
        public int S_studentId { get; set; }
        public string S_firstName { get; set; }
        public string S_lastName { get; set; }
        public string S_EmailAddress { get; set; }

        public string S_phoneNumber { get; set; }



    }
}
