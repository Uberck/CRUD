﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDweb.Models;

namespace CRUDweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
        
            return View();
        }
        public IActionResult Lookup()
        {
            ViewData["Message"] = "Search for employee by lastname";

            return View();
        }

        [HttpPost]
        public IActionResult Lookup(EmployeeModel model)
        {
            if (ModelState.IsValid)

            {
                return RedirectToAction("Index");
            }

            return View();
        }
        // other buttons commented out for now
        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";
        //
        //   return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
