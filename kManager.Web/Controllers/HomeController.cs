using kManager.Domain;
using kManager.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db = new DepartmentDB();

        public HomeController(IDepartmentDataSource departmentDatasource)
        {
            this._db = departmentDatasource;
        }


        public string HelloWorld()
        {
            string result = "";
            for(int i = 0; i < 5; i++)
            {
                result += "Hello World! ";
            }

            return result;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;

            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}