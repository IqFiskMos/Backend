using EFW_Assignment.Data;
using EFW_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFW_Assignment.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult StudentView()
        {
            var student = _context.Students.ToList();
            return View(student);
        }

        public IActionResult CreateStudent()
        {
            if (!ModelState.IsValid)
            {
                return View("CreateStudent");
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(Student member)
        {
            if (String.IsNullOrEmpty(member.FirstName) || String.IsNullOrEmpty(member.City))
            {
                return View();
            }
            else
            {
                _context.Students.Add(member);
                _context.SaveChanges();
                return RedirectToAction("StudentView");
            }
        }

        public IActionResult EditStudent(int id)
        {
            var member = _context.Students.Where(s => s.StudentId == id).FirstOrDefault();

            return View(member);
        }

        [HttpPost]
        public ActionResult EditStudent(Student data)
        {
            var member = _context.Students.Where(s => s.StudentId == data.StudentId).FirstOrDefault();

            if (String.IsNullOrEmpty(data.FirstName) || data.StudentId == 0)
            {
                return View();
            }
            else
            {                
                member.StudentId = data.StudentId;
                member.FirstName = data.FirstName;
                member.LastName = data.LastName;
                member.Qualification = data.Qualification;
                member.City = data.City;

                _context.SaveChanges();

                return RedirectToAction("StudentView");
            }
        }

        public ActionResult DeleteStudent(int id)
        {
            var data = _context.Students.Where(x => x.StudentId == id).FirstOrDefault();
            _context.Students.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("StudentView");
        }

        public IActionResult StudentDetails(int id)
        {
            var member = _context.Students.Where(s => s.StudentId == id).FirstOrDefault();
            return View(member);
        }

    }
}
