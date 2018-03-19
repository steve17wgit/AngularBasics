using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularBasics.Controllers
{
    public class AngularController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult Expressions()
        {
            return View();
        }

        public IActionResult Modules()
        {
            return View();
        }

        public IActionResult Directives()
        {
            return View();
        }

        public IActionResult Model()
        {
            return View();
        }

        public IActionResult DataBinding()
        {
            return View();
        }

        public IActionResult Controllers()
        {
            return View();
        }

        public IActionResult Scope()
        {
            return View();
        }

        public IActionResult Filters()
        {
            return View();
        }
    }
}