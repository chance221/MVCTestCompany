using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "manager Index";
                return View("ManagerIndex");
            }
            else
                return View();
        }

        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }

        public string ListAllCustomers()
        {
            return
             @"
            <ul>
            <li>Fred Flintstone</li>
            <li>Judy Jetson</li>
            <li>Shaggy Rogers</li>
            <li>Daphne Blake</li>
            </ul>";

        }

        [HttpPost]
        public ActionResult NewEmployeeForm(string FirstName, string LastName, string Title)
        {
            ViewBag.Message = "Name: " + FirstName + " " + LastName;
            ViewBag.Message += " Title: " + Title;
            return View("ConfirmEmployee");
        }

        public ActionResult NewEmployeeForm()
        {
            return View("NewEmployeeForm");
        }
    }
}