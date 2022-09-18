using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelInMVC.Models;

namespace ModelInMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }


        //  GetEmployee is a method which is used to get data and its return type is employee type
        // and this method is used to return the data.


        private Employee GetEmployee()
        {
            return new Employee()
            {

                Id = 1,
                Address = "India",
                Name = "WebGentle"

            };
        }


    }
}