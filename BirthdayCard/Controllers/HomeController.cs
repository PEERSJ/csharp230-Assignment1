using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Jeff Peerson
//CSHP230  MVC  - Assignment 1 - BirthdayCard

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult BirthdayMessage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult BirthdayMessage(Models.BirthdayCard birthdayCard)
        {
            return View(birthdayCard);
        }
    }
}