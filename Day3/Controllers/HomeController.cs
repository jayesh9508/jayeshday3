using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string  id)
        {
            TempData["value"] = id;
            TempData.Keep("value");
            return View();
       
        }

        public ActionResult Thankyou()
        {

            return View();
        }

       
        }
    }
