using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1st.Controllers
{
    public class PagesController : Controller
    {
       
        public  ActionResult Idex()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}