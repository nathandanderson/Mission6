﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext blahContext { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }


        //Display page for new Task Form
        [HttpGet]
        public IActionResult NewTask()
        {
            ViewBag.Categories = blahContext.Categories.OrderBy(x => x.CategoryName).ToList();

            return View();
        }

        //Posting form information page
        [HttpPost]
        public IActionResult newTask(Task nt)
        {
            if (ModelState.IsValid)
            {
                //writing to sql database and saving
                blahContext.Add(nt);
                blahContext.SaveChanges();
            }
            else
            {
                ViewBag.Categories= blahContext.Categories.OrderBy(x => x.CategoryName).ToList();
                return View(nt);
            }
            return View("Confirmation", nt);
        }

        [HttpGet]
        public IActionResult TaskList()
        {
            var tasks = blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(tasks);
        }

    }
}
