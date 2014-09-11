using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogAttributeClassDemo.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomError()
        {
            string date = TempData["ErrorDate"] as string;
            string action = TempData["Action"] as string;
            string controller = TempData["Controller"] as string;

            return this.Content(string.Format(@"{{ErrorDate:{0},Action:""{1}"",Controller:""{2}""}}", 
                date, action, controller), "application/json");
        }

    }
}
