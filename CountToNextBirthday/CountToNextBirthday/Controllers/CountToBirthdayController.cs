using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CountToNextBirthday.Models;

namespace CountToNextBirthday.Controllers
{
    public class CountToBirthdayController : Controller
    {
        // GET: CoutToBirthday
        public ActionResult Index()
        {
            return View("Index");
        }

        // POST: CountToBirthday
        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index_POST(NextBirthday model)
        {
            if(ModelState.IsValid)
            {
                return View("UpComingBirthday", model);
            }
            return View();
        }
    }
}