using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Areas.Admin.Data;
using Cinema.Areas.Admin.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;

namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;
     
        public HomeController(DPContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();  
        }

        public IActionResult SignUp()
        {
            return View();
        }




    }
}
