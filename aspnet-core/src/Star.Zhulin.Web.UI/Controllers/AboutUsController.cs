using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Star.Zhulin.Web.UI.Controllers
{
    public class AboutUsController : Controller
    { 
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "aboutus";
            return View();
        }
    }
}