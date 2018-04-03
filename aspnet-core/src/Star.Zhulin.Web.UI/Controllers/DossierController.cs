using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Star.Zhulin.Web.UI.Controllers
{
    public class DossierController : Controller
    { 
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "dossier";
            return View();
        }
    }
}