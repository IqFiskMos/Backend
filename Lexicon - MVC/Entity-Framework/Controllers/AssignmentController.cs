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
    public class AssignmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssignmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AssignmentView()
        {
            var assignment = _context.Assignments.ToList();
            return View(assignment);
        }
        public IActionResult CreateAssignment()
        {
            ViewBag.CoursesNames = new SelectList(_context.Courses, "CourseId", "CourseName");

            if (!ModelState.IsValid)
            {
                return View("CreateAssignment");

            }
            return View();
        }
        [HttpPost]
        public ActionResult CreateAssignment(Assignment member)
        {
            if (String.IsNullOrEmpty(member.Name) || member.CourseId == 0)
            {
                return View();
            }
            else
            {
                _context.Assignments.Add(member);
                _context.SaveChanges();
                return RedirectToAction("AssignmentView");

            }

        }

        public IActionResult EditAssignment(int id)
        {
            Assignment assignment = _context.Assignments.Find(id);
            ViewBag.CourseId = new SelectList(_context.Courses, "CourseId", "CourseName", assignment.CourseId);
            var member = _context.Assignments.Where(s => s.AssignmentId == id).FirstOrDefault();

            return View(member);
        }
        [HttpPost]
        public ActionResult EditAssignment(Assignment data)
        {
            var member = _context.Assignments.Where(s => s.AssignmentId == data.AssignmentId).FirstOrDefault();

            if (String.IsNullOrEmpty(data.Name) || data.CourseId == 0)
            {
                return View();
            }
            else
            {
                member.Name = data.Name;
                member.CourseId = data.CourseId;
                
                _context.SaveChanges();

                return RedirectToAction("AssignmentView");
            }
        }

        public ActionResult DeleteAssignment(int id)
        {
            var data = _context.Assignments.Where(x => x.AssignmentId == id).FirstOrDefault();
            _context.Assignments.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("AssignmentView");
        }
        public IActionResult AssignmentDetails(int id)
        {
            var member = _context.Assignments.Where(s => s.AssignmentId == id).FirstOrDefault();
            return View(member);
        }
    }
}
