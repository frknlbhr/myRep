using MySimpleMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySimpleMvcProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentList.isDeleted = false;
            //TempData["Message"] = null;
            ViewData["StdList"] = StudentList.studentList;

            return View();
        }

        public ActionResult Add(Student studentModel)
        {
            StudentList.AddStudentToList(studentModel.Name, studentModel.Surname);
            StudentList.SortStudentList();
            ViewData["StdList"] = StudentList.studentList;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Student studentModel)
        {
            StudentList.DeleteStudentFromList(studentModel);
            //TempData["Message"] = StudentList.message;
            StudentList.SortStudentList();

            ViewData["StdList"] = StudentList.studentList;

            return RedirectToAction("Index");
        }
    }
}