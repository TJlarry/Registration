﻿using CourseRegistration.Controllers.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepo _repo1;

        public InstructorController(IInstructorRepo repo1)
        {
            _repo1 = repo1;
        }

        public IActionResult Index()
        {
            return View(_repo1.GetAllInstructor());
        }
    }
}