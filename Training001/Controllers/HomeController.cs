using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Training001.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //Start bugfix001
            ViewBag.Title = "ホーム画面";
            //End   bugfix001
            return View("index","_Layout");
        }

    }
}
