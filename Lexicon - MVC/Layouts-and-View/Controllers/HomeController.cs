using Layouts_and_Views.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Layouts_and_Views.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        
        public IActionResult About()
        {
            List<EducationModel> edu = new List<EducationModel>
            {
                new EducationModel {Year = "Present", Name = ".NET programming", Clg = "Lexicon", Place = "Göteborg"},
                new EducationModel {Year = "2021(Jan-Mars)", Name = "Yrkessvenska", Clg = "Hermods", Place = "Mölndal"},
                new EducationModel {Year = "2020(Ock) - 2021(Jan)", Name = "SASG B", Clg = "ABF Vux", Place = "Göteborg"},
                new EducationModel {Year = "2019(Ock) - 2020(Jun)	", Name = "SFI", Clg = "KOMVUX", Place = "Eskilstuna"},
                new EducationModel {Year = "2012-2014", Name = "Masters", Clg = "Sathyabama University	", Place = "Chennai, India"},
                new EducationModel {Year = "2008-2012", Name = "Bachelors", Clg = "RVPECW, JNTUA", Place = "Kadapa, India"}
            };
            ViewBag.Edu = edu;
            return View();
        }
        
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Experience()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
