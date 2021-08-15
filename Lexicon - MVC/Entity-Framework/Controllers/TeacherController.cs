using EFW_Assignment.Data;
using EFW_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult TeacherView()
        {
            var teacher = _context.Teachers.ToList();
            return View(teacher);
        }

        public IActionResult CreateTeacher()
        {
            ViewBag.CoursesNames = new SelectList(_context.Courses, "CourseId", "CourseName");
            if (!ModelState.IsValid)
            {
                return View("CreateTeacher");
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeacher(Teacher member)
        {
            if (String.IsNullOrEmpty(member.Name) || member.CourseId == 0)
            {
                return View();
            }
            else
            {
                _context.Teachers.Add(member);
                _context.SaveChanges();
                return RedirectToAction("TeacherView");

            }

        }

        public IActionResult EditTeacher(int id)
        {
            Teacher teacher = _context.Teachers.Find(id);
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName", teacher.CourseId);
            var member = _context.Teachers.Where(s => s.TeacherId == id).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public ActionResult EditTeacher(Teacher data)
        {
            var member = _context.Teachers.Where(s => s.TeacherId == data.TeacherId).FirstOrDefault();

            if (String.IsNullOrEmpty(data.Name) || data.CourseId == 0)
            {
                return View();
            }
            else
            {
                member.Name = data.Name;
                member.CourseId = data.CourseId;
                _context.SaveChanges();

                return RedirectToAction("TeacherView");
            }
        }

        public ActionResult DeleteTeacher(int id)
        {
            var data = _context.Teachers.Where(x => x.TeacherId == id).FirstOrDefault();
            _context.Teachers.Remove(data);
            _context.SaveChanges();
            //ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("TeacherView");
        }

        public IActionResult TeacherDetails(int id)
        {
            var member = _context.Teachers.Where(s => s.TeacherId == id).FirstOrDefault();
            return View(member);
        }
    }
}
