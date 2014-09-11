using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogAttributeClassDemo.Attributes;

namespace LogAttributeClassDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [CustomError]
        public ActionResult TestError()
        {
            throw new Exception("Test Error");
            return View();
        }

    }
}
