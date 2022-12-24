using CodeFirst_Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst_Project1.Controllers
{
    public class HomeController : Controller
    {
        YenilikEvimModel db = new YenilikEvimModel();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}