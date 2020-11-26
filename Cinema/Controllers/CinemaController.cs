using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Cinema_List()
        {
            return View();
        }
    }
}
