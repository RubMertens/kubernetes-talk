using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Color.Web.Models;

namespace Color.Web.Controllers
{
    public class 
        HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ColorService _colorService;

        public HomeController(ILogger<HomeController> logger, ColorService colorService)
        {
            _logger = logger;
            _colorService = colorService;
        }

        public IActionResult Index()
        {
            ViewBag.Color = _colorService.Color;
            return View();
        }
    }
}
