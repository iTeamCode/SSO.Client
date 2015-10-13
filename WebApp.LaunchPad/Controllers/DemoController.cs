using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.LaunchPad.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Demo/Signin
        public ActionResult Signin()
        {
            return View();
        }
	}
}