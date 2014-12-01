using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CountToNextBirthday.Models;

namespace CountToNextBirthday.Controllers
{
    public class HomeController : Controller
    {
        // GET: CoutToBirthday
        public ActionResult Index()
        {
            return View("Index");
        }

        // POST: CoutToBirthday
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index_POST()
        {
            var model = new NextBirthday
            {
                Birthdate = DateTime.Parse(Request.Form["birthday"])
            };

            return View("UpComingBirthday", model);
        }
    }
}