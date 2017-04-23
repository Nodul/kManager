using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kManager.Web.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            ViewBag.Message = "Example page using ExampleController";
            return View();
        }
        [Authorize] // can also add params for better control who can access
        public ActionResult Secret()
        {
            ViewBag.Message = "Secret";
            return View();
        }
    }
}