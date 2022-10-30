using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using u21529664_HW06.Models;

namespace u21529664_HW06.Controllers
{
    public class ReportController : Controller
    {
        private readonly BikeStoresEntities db = new BikeStoresEntities();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }
        public string GetReport()
        {
            db.Configuration.ProxyCreationEnabled = false;
            object bikes = db.orders.Select(b => new
            {
                month = b.order_date.Month,
                bike = db.order_items.Where(k => k.order_id == b.order_id && k.product.category.category_name == "Mountain Bikes").ToList(),
            }).ToList();

            return JsonConvert.SerializeObject(bikes);
        }

    }
}