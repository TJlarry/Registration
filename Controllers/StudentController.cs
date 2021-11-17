using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models.ModelsDto;
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentDto input)
        {
            _repo2.CreateStudent(input);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_repo2.GetStudent(id));
        }
        [HttpPost]
        public IActionResult Update(StudentDto input)
        {
            _repo2.UpdateStudent(input);
            return RedirectToAction("Index");
        }

    }
}
