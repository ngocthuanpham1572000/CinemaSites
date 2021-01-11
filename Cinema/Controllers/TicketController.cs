using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult BookStep_1()
        {
            return View();
        }

        public IActionResult BookStep_2()
        {
            return View();
        }


        public IActionResult BookStep_Final()
        {
            return View();
        }
    }
}
