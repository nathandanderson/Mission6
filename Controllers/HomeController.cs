using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks.Task;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext blahContext { get; set; }
        public HomeController(TaskContext someName)
        {
            blahContext = someName;
        }

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
        public IActionResult NewTask(Task nt)
        {
            if (ModelState.IsValid)
            {
                //writing to sql database and saving
                blahContext.Add(nt);
                blahContext.SaveChanges();

                return RedirectToAction("Quadrants");
                //return View("Quadrants", nt);
            }
            else
            {
                ViewBag.Categories= blahContext.Categories.OrderBy(x => x.CategoryName).ToList();
                return View(nt);
            }
        }

        [HttpGet]
        public IActionResult Quadrants()
        {
            var tasks = blahContext.Entries
                .Include(x => x.Category)
                .OrderBy(x => x.TaskName)
                .ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Edit(int TaskID)
        {
            ViewBag.Categories = blahContext.Categories.OrderBy(x => x.CategoryName).ToList();

            var task = blahContext.Entries.Single(x => x.TaskID ==TaskID);

            return View("NewTask", task);
        }
        // Saving the edits they made on the edit page.
        [HttpPost]
        public IActionResult Edit(Task blah)
        {
            blahContext.Update(blah);
            blahContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }

        //Render the delete page for a given movie
        [HttpGet]
        public IActionResult Delete(int TaskID)
        {
            var task = blahContext.Entries.Single(x => x.TaskID == TaskID);

            return View(task);
        }

        //Actually delete the movie after asking for confirmation
        [HttpPost]
        public IActionResult Delete(Task tr)
        {
            blahContext.Entries.Remove(tr);
            blahContext.SaveChanges();

            return RedirectToAction("Quadrants");
        }

    }
}
