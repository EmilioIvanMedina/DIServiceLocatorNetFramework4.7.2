using DIServiceLocatorInfrastructure.Interfaces;
using DIServiceLocatorPresentation.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIServiceLocatorPresentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //it's the same idea of the workaround of Method Injection, but we have a new static class
            //check https://github.com/EmilioIvanMedina/DIMethodInjectionNetFramework4.7.2 
            var service = ServiceLocator.GetService<ISampleService>();
            var myName = service.GetName();
            return View();
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