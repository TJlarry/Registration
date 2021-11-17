using CourseRegistration.Controllers.Data.Interfaces;
using CourseRegistration.Models.ModelsDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepo _repo;

        public CourseController(ICourseRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAllCourses());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CourseDto input)
        {
            _repo.CreateCourse(input);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            
            return View(_repo.GetCourse(id));
        }
        [HttpPost]
        public IActionResult Update(CourseDto input)
        {
            _repo.UpdateCourse(input);
            return RedirectToAction("Index");



        }



        }
}
