using EFW_Assignment.Data;
using EFW_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult CourseView()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }
        public IActionResult CreateCourse()
        {
            if (!ModelState.IsValid)
            {
                return View("CreateCourse");
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateCourse(Course member)
        {
            if (String.IsNullOrEmpty(member.CourseName) || String.IsNullOrEmpty(member.TimePeriod))
            {
                return View();
            }
            else
            {
                _context.Courses.Add(member);
                _context.SaveChanges();
                return RedirectToAction("CourseView");
            }
        }

        public IActionResult EditCourse(int id)
        {
            var member = _context.Courses.Where(s => s.CourseId == id).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public ActionResult EditCourse(Course data)
        {
            var member = _context.Courses.Where(s => s.CourseId == data.CourseId).FirstOrDefault();

            if (String.IsNullOrEmpty(data.CourseName) || data.CourseId == 0)
            {
                return View();
            }
            else
            {
                member.CourseName = data.CourseName;
                member.TimePeriod = data.TimePeriod;
                _context.SaveChanges();

                return RedirectToAction("CourseView");
            }
        }

        public ActionResult DeleteCourse(int id)
        {
            var data = _context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
            _context.Courses.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("CourseView");
        }

        public IActionResult CourseDetails(int id)
        {
            List<StudentCourse> studentlist = new List<StudentCourse>();
            studentlist = _context.StudentCourses.ToList();
            List<Student> slist = new List<Student>();
            slist = _context.Students.ToList();
            List<Course> courselist = new List<Course>();
            courselist = _context.Courses.ToList();
            List<Teacher> teacherlist = new List<Teacher>();
            teacherlist =  _context.Teachers.ToList();
            List<Assignment> assignmentlist = new List<Assignment>();
            assignmentlist = _context.Assignments.ToList();

            var member = _context.Courses.Where(s => s.CourseId == id).FirstOrDefault();

            ViewBag.StudentData = (from s in slist
                                   join sc in studentlist
                                   on s.StudentId equals sc.StudentId
                                   where sc.CourseId == id
                                   select new CourseVM { slist = s, studentlist = sc }).ToList();
            ViewBag.TeacherData = (from t in teacherlist
                                   join c in courselist
                                   on t.CourseId equals c.CourseId
                                   where c.CourseId == id
                                   select new CourseVM { teacherlist = t, courselist = c }).ToList();
            ViewBag.AssignmentData = (from a in assignmentlist
                                   join c in courselist
                                   on a.CourseId equals c.CourseId
                                   where c.CourseId == id
                                   select new CourseVM { assignmentlist = a, courselist = c }).ToList();
            return View(member);
        }
    }
}
