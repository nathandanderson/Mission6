using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext daContext { get; set; }

        // Constructor
        public HomeController(TaskContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewTask()
        {
            return View();
        }

    }
}
