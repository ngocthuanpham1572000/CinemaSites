﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
