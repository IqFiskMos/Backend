using FormsAndInputsAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsAndInputsAssignment.Controllers
{
    public class FeverCheckController : Controller
    {
        public IActionResult FeverCheckView()
        {
            
            return View();
        }
        public ActionResult FeverCheck(double userInput, string type)
        {
            ViewBag.result = FeverCheckModel.FeverCheckEvaluation(userInput, type);
            return View("FeverCheckView");
        }
        
    }
}
