using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Color.Web.Models;
using Microsoft.Extensions.Configuration;

namespace Color.Web.Controllers
{
    public class 
        HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ColorService _colorService;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, ColorService colorService, IConfiguration configuration)
        {
            _logger = logger;
            _colorService = colorService;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Name = _configuration["POD_NAME"];
            ViewBag.Color = _colorService.Color;
            return View();
        }
    }
}
