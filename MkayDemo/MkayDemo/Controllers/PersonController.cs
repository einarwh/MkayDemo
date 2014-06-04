using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MkayDemo.Models;

namespace MkayDemo.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            var p = new Person
            {
                BirthDate = new DateTime(1980, 1, 1),
                DeathDate = new DateTime(2080, 1, 1),
                LastSeen = new DateTime(2060, 1, 1)
            };
            return View(p);
        }

        [HttpPost]
        public ActionResult Index(Person p)
        {
            return View(p);
        }

    }
}
