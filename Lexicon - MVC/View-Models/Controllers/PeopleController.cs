using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using View_Models.Models;

namespace View_Models.Controllers
{
    public class PeopleController : Controller
    {
        static List<PeopleModel> peopleList = new List<PeopleModel>
            {
                new PeopleModel { Id = 1, Name = "Tony", Phone = 12234, City = "Los Santos"},
                new PeopleModel { Id = 2, Name = "Luke", Phone = 3544, City = "Sandy" },
                new PeopleModel { Id = 3, Name = "Sussie", Phone = 35644, City = "Paleto" },
                new PeopleModel { Id = 4, Name = "Abdi", Phone = 75684, City = "Harbor" },
                new PeopleModel { Id = 5, Name = "Frank", Phone = 78902, City = "Grovestreet" },
                new PeopleModel { Id = 5, Name = "Zelda", Phone = 73902, City = "Perrera" },
            };
        
        public IActionResult PeopleView()
        {
            return View(peopleList.OrderBy(s => s.Name).ToList());           
        }
        [HttpPost]
        public IActionResult PeopleView(string search, bool CaseSensitive, bool CaseInSensitive)
        {
            var result = peopleList.ToList();
            if (String.IsNullOrEmpty(search))
            {
                ViewBag.result = "Please enter some input";
                ViewBag.Back = true;
            }
            else
            {
                if (CaseSensitive == true)
                {
                    ViewBag.Back = true;
                    result = peopleList.Where(x => x.City.StartsWith(search) || x.Name.StartsWith(search) || search == null).ToList();
                }
                else
                {
                    ViewBag.Back = true;
                    result = peopleList.Where(x => x.City.ToLower().StartsWith(search.ToLower()) || x.Name.ToLower().StartsWith(search.ToLower()) || search == null).ToList();
                }
            }
            return View(result);
        }
        
        public IActionResult EditPeople(int id)
        {
            var member = peopleList.Where(s => s.Id == id).FirstOrDefault();

            return View(member);
        }
        [HttpPost]
        public ActionResult EditPeople(PeopleModel member)
        {
            if (String.IsNullOrEmpty(member.Name) || member.Phone == 0 || String.IsNullOrEmpty(member.City))
            {
                return View();
            }
            else
            {
                var people = peopleList.Where(s => s.Id == member.Id).FirstOrDefault();
                peopleList.Remove(people);
                peopleList.Add(member);
                return RedirectToAction("PeopleView");
            }
        }
        public IActionResult CreatePeople()
        {
            if (!ModelState.IsValid)
            {
                return View("CreatePeople");

            }
            return View();
        }
        [HttpPost]
        public ActionResult CreatePeople(PeopleModel member)
        {
            if (String.IsNullOrEmpty(member.Name) || member.Phone == 0 || String.IsNullOrEmpty(member.City))
            {
                return View();
            }
            else
            {
                member.Id = peopleList.Count + 1;
                peopleList.Add(member);
                return RedirectToAction("PeopleView");
                
            }  
            
        }
        public IActionResult DetailsPeople(int id)
        {
            var member = peopleList.Where(s => s.Id == id).FirstOrDefault();
            return View(member);
        }

        public ActionResult DeletePeople(int id)
        {
            var people = peopleList.Where(s => s.Id == id).FirstOrDefault();
            peopleList.Remove(people);
            return RedirectToAction("PeopleView");
        }       

    }
}
