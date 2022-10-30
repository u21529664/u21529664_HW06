using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21529664_HW06.Models;

namespace u21529664_HW06.Controllers
{
    public class OrderVMController : Controller
    {

        private readonly BikeStoresEntities db = new BikeStoresEntities();
        // GET: OrderVM
        public ActionResult Index()
        {

            List<OrderVM> orders = db.order_items.Select(k => new OrderVM {
                OrderID = k.order_id, 
                CategoryName = k.product.category.category_name, 
                Product = db.products.Where(x => x.product_id == k.product_id).FirstOrDefault(),
                Quantity = k.quantity, ListPrice = k.list_price, 
                GrandTotal = (k.list_price * k.quantity), 
                OrderDate = db.orders.Where(b => b.order_id == k.order_id).FirstOrDefault().order_date 
            }).ToList();
            return View(orders);
        }

        public ActionResult SearchOrders(DateTime date )
        {

            List<OrderVM> orders = db.order_items.Where(b => b.order4.order_date <= date).Select(k => new OrderVM { OrderID = k.order_id, CategoryName = k.product.category.category_name, Product = db.products.Where(p => p.product_id == k.product_id).FirstOrDefault(), Quantity = k.quantity, ListPrice = k.list_price, GrandTotal = (k.list_price * k.quantity), OrderDate = db.orders.Where(b => b.order_id == k.order_id).FirstOrDefault().order_date }).ToList();
            return View("Index", orders);
        }
    }
}
