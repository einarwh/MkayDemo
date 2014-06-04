using System;
using System.Web.Mvc;

using MkayDemo.Models;

namespace MkayDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
