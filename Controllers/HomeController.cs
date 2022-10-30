using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21529664_HW06.Models;
using Newtonsoft.Json;
using System.Net;
using PagedList;
using PagedList.Mvc;

namespace u21529664_HW06.Controllers
{
    public class HomeController : Controller
    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();
        public ActionResult Index()
        {
            return View();
        }


      


    }
}