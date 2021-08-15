using Guessing_Game.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Guessing_Game.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GameView()
        {
            int randomNum = GuessingGameModel.GetGuessNumber();
            HttpContext.Session.SetInt32("rndValue", randomNum);
            return View();
        }
        public IActionResult CheckGuessing(int input)
        {     
            int gameNum = (int) HttpContext.Session.GetInt32("rndValue");
            ViewBag.Message = GuessingGameModel.CheckGuess(input, gameNum);
            return View("GameView");

        }
        public IActionResult Reset()
        {
            GuessingGameModel.StoreNums.Clear();
            int randomNum = GuessingGameModel.GetGuessNumber();
            HttpContext.Session.SetInt32("rndValue", randomNum);
            return View("GameView");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
