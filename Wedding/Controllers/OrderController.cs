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
                             join t2 in db.LeiBie
                             on t1.LeiBieId equals t2.LeiBieId

                             select new OrderViewModel
                             {
                                 OrderDate = t1.OrderDate,
                                 OrderId = t1.OrderId,
                                 Total = t1.Total,
                                 UserName = t1.Username,
                                 Count = t1.Count,
                                 Name = t2.Name
                             }).ToList();
                return View(query);
            }
            else
                return RedirectToAction("Login", "Acount");

        }
    }
}