using System;
using Microsoft.AspNetCore.Mvc;


namespace SampleSecuredWeb.Controllers
{
    public class StudentController : Controller
    {
       public IActionResult Index(){
            return View();
        }
        public IActionResult Create(){
            return View();
        }
        public IActionResult Edit(){
            return View();
        }
        public IActionResult Delete(){
            return View();
        }

    }
}