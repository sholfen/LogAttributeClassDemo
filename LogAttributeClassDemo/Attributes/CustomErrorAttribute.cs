using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogAttributeClassDemo.Controllers;

namespace LogAttributeClassDemo.Attributes
{
    public class CustomErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                filterContext.Controller.TempData["ErrorDate"] = DateTime.Now.ToString();
                filterContext.ExceptionHandled = true;
                ErrorController errorController = new ErrorController();

                string action = filterContext.RequestContext.RouteData.Values["action"].ToString();
                string controller = filterContext.RequestContext.RouteData.Values["controller"].ToString();
                filterContext.Controller.TempData["Action"] = action;
                filterContext.Controller.TempData["Controller"] = controller;

                errorController.TempData = filterContext.Controller.TempData;
                filterContext.Result = errorController.CustomError();
                //base.OnException(filterContext);
            }
        }
    }
}

