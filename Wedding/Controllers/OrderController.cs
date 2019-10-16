using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wedding.Models;
using Wedding.ViewModels;

namespace Wedding.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        WeddingEntity db = new WeddingEntity();
        public ActionResult Index(string userName)
        {
            if (userName != null)
            {
                var query = (from t1 in db.Order
                             join t2 in db.Prouduct
                             on t1.ProuductId equals t2.ProuductId
                             where t1.Username==userName
                             select new OrderViewModel
                             {
                                 OrderDate = t1.OrderDate,
                                 OrderId = t1.OrderId,
                                 Total = t1.Total,
                                 UserName = t1.Username,
                                 Count = t1.Count,
                                 Name = t2.Varieties,
                                 Tupian =t2.TuPian
                                 
                             }).ToList();
                var total = db.Order.Where(a => a.Username == userName).Sum(a => a.Total);
                OrderTotal orderTotal = new OrderTotal();
                orderTotal.OrderViewModels = query;
                orderTotal.Total = total;
                return View(orderTotal);


            }
            else
                return RedirectToAction("Login", "Acount");

        }
    }
}