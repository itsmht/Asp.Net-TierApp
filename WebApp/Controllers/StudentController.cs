using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace WebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            var data = StudentService.Get();
            return View(data);
        }
        [HttpPost]
        public ActionResult Create(StudentModel s)
        {
            StudentService.Create(s);
            return RedirectToAction("Create");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = StudentService.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(StudentModel s)
        {
            StudentService.Edit(s);
            return RedirectToAction("Create");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = StudentService.Get(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(StudentModel s)
        {
            StudentService.Delete(s);
            return RedirectToAction("Create");
        }
    }
}