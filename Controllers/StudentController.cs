using RemoteValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidation.Controllers
{
    public class StudentController : Controller
    {

        private MvcDemoEntities demoEntities = new MvcDemoEntities();
        // GET: Student
        public ActionResult Index()
        {
            var students = demoEntities.Students.ToList();
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(User model)
        {
          
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    StudentId = model.StudentId,
                    StudentName = model.StudentName,
                    MobileNo = model.MobileNo,
                    Class = model.Class,
                    Gender = model.Gender,
                    LoginId = model.LoginId
                };
                demoEntities.Students.Add(student);
                demoEntities.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public JsonResult IsUserNameAvailable(string LoginId)
        {
            return Json(!demoEntities.Students.Any(x => x.LoginId == LoginId),
                                                 JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsUserAvailable(int StudentId)
        {
            return Json(!demoEntities.Students.Any(x => x.StudentId == StudentId),
                                                 JsonRequestBehavior.AllowGet);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
