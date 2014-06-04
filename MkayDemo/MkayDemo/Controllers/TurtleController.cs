using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MkayDemo.Models;

namespace MkayDemo.Controllers
{
    public class TurtleController : Controller
    {
        //
        // GET: /Turtle/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Turtle t)
        {
            return View(t);
        }


    }
}
