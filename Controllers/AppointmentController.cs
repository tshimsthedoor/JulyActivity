﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JulyActivity.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);
        }
    }
}
