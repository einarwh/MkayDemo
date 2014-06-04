using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MkayDemo.Models;

namespace MkayDemo.Controllers
{
    public class GuardianController : Controller
    {
        //
        // GET: /Eval/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Guardian g)
        {
            return View(g);
        }


    }
}
