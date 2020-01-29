using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //public string Index(string id)
        //{
        //    return "Your ID=" + id;
        //}

        public string Index(string company)
        {
            return "Your company name is " + company;
        }

        /*A note about sharing data. 
         -HtmlEncode is used if you are passing parameters or data that conains spaces(like URL parameters) and typically used if you are passing data in through the parameters
         
        -Server.HtmlEncode(parameterName) The HTMLEncode method applies HTML encoding to a specified string. 
        It is used as a quick way to encode form data and other client request data before using it in your Web application. 
        This method is typically used with data from forms.

        What is the difference between HttpUtility.HtmlEncode and Server.HtmlEncode?

            Server.HtmlEncode uses a specific instance of the System.Web.HttpServerUtility class that's inherited from the Page class. 

            HttpUtility.HtmlEncode is a static method, so you don't have to instantiate the HttpUtility class.

            All else being equal, you should go with the static HttpUtility.HtmlEncode because it is a static method and you don't have to instantiate the HttpUtility class.

            This will prevent data being transmitted from being displayed in the browser
        */
        public ActionResult CustomerNumber(string id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your temperory customer number is: " + id);
            return View();
        }

        public string Company(string name)
        {
            return HttpUtility.HtmlEncode("Your Company name is " + name);
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

        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("ListAllCustomers", "Customer");
        }

        

    }
}