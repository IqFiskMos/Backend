using EFW_Assignment.Data;
using EFW_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentCourseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult StudentCourseView()
        {
            var studentcourse = _context.StudentCourses.Include(s => s.Student).Include(c =>c.Course);
            return View(studentcourse.ToList());
        }

        public IActionResult CreateStudentCourse()
        {
            ViewBag.CourseNames = _context.Courses;
            ViewBag.StudentNames = new SelectList(_context.Students, "StudentId", "FirstName");

            if (!ModelState.IsValid)
            {
                return View("CreateStudentCourse");
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudentCourse(int StudentId, int []CourseIds)
        {            
                int i = 0;
                var crsId = _context.StudentCourses
                                .Where(st => st.StudentId == StudentId)
                                .Select(st => new {
                                    Id = st.CourseId }).ToList();
                foreach(var Id in crsId)
                {
                    if(Id.Id == CourseIds[i])
                    {
                        ViewBag.ErrorMsg = "CourseId " + CourseIds[i] + " is already assigned to this student.";
                        i++;
                        return View();
                     }
                }
                foreach(int courseId in CourseIds)
                {                    
                    StudentCourse stdcourses = new StudentCourse();
                    stdcourses.StudentId = StudentId;
                    stdcourses.CourseId = courseId;
                    _context.StudentCourses.Add(stdcourses);
                    _context.SaveChanges();
                }                
                return RedirectToAction("StudentCourseView");        
        }

        public IActionResult EditStudentCourse(int id, int stdId)
        {
            var member = _context.StudentCourses.Where(s => s.StudentId == stdId && s.CourseId==id ).FirstOrDefault();
            return View(member);
        }
        [HttpPost]
        public ActionResult EditStudentCourse(StudentCourse data)
        {
            var member = _context.StudentCourses.Where(s => s.StudentId == data.StudentId ).FirstOrDefault();

            if (data.StudentId == 0 || data.CourseId == 0)
            {
                return View();
            }
            else
            {
                member.StudentId = data.StudentId;
                member.CourseId = data.CourseId;

                _context.SaveChanges();

                return RedirectToAction("StudentCourseView");
            }
        }

        public ActionResult DeleteStudentCourse(int id)
        {
            var data = _context.StudentCourses.Where(x => x.CourseId == id).FirstOrDefault();
            _context.StudentCourses.Remove(data);
            _context.SaveChanges();
            //ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("StudentCourseView");
        }
        public IActionResult StudentCourseDetails(int id)
        {
            var member = _context.StudentCourses.Where(s => s.CourseId == id).FirstOrDefault();
            return View(member);
        }
    }
}
