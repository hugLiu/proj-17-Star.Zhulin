using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Star.Zhulin.Web.UI.Controllers
{
    public class LeftController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }
    }
}