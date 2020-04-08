using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServerApp.Models;
using ServerApp.Services;

namespace ServerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IForum _forumService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IForum forumService)
        {
            _logger = logger;
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var products = _forumService.GetAll();
            return View(products);
        }

        public IActionResult Privacy()
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
