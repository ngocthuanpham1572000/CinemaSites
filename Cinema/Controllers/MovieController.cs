using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Movie_Detail()
        {
            return View();
        }
        public IActionResult Movie_Detail_CommingSoon()
        {
            return View();
        }

        public IActionResult MovieList_NowPlaying()
        {
            return View();
        }



        public IActionResult MovieList_CoomingSoon()
        {
            return View();
        }

    }
}
