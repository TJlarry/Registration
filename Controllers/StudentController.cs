using CourseRegistration.Controllers.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo _repo2;

        public StudentController(IStudentRepo repo2)
        {
            _repo2 = repo2;
        }

        public IActionResult Index()
        {
            return View(_repo2.GetAllStudent());
        }
    }
}
