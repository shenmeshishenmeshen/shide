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
        FlowersEntity db = new FlowersEntity();
        public ActionResult Index(string userName)
        {
            if (userName != null)
            {
                var query = (from t1 in db.Order
                             join t2 in db.Prouduct
                             on t1.ProuductId equals t2.ProuductId
                             where t1.Username == userName
                             select new OrderViewModel
                             {
                                 OrderDate = t1.OrderDate,
                                 OrderId = t1.OrderId,
                                 Total = t1.Total,
                                 UserName = t1.Username,
                                 Count = t1.Count,
                                 Name = t2.Varieties,
                                 Tupian = t2.TuPian

                             }).ToList();
                var total = query.Sum(a => a.Total);
                OrderTotal orderTotal = new OrderTotal();
                orderTotal.OrderViewModels = query;
                orderTotal.Total = total;
                return View(orderTotal);


            }
            else
                return RedirectToAction("Login", "Acount");

        }

        public ActionResult List()
        {
            var query = (from t1 in db.Order
                         join t2 in db.Prouduct
                         on t1.ProuductId equals t2.ProuductId
                         select new OrderMan
                         {
                             OrderDate = t1.OrderDate,
                             OrderId = t1.OrderId,
                             Total = t1.Total,
                             UserName = t1.Username,
                             Count = t1.Count,
                             Name = t2.Varieties,
                             Tupian = t2.TuPian,
                             LeiBie=t2.LeiBie.Name,
                             Email = t1.Email,
                             Address = t1.Address
                         }).ToList();
            return View(query);
        }

        public ActionResult Edit(string id)
        {
            var album = (from t1 in db.Order
                         join t2 in db.Prouduct
                         on t1.ProuductId equals t2.ProuductId
                         where t1.OrderId == id
                         select new OrderMan
                         {
                             OrderDate = t1.OrderDate,
                             OrderId = t1.OrderId,
                             Total = t1.Total,
                             UserName = t1.Username,
                             Count = t1.Count,
                             Name = t2.Varieties,
                             Tupian = t2.TuPian,
                             LeiBie = t2.LeiBie.Name,
                             Email=t1.Email,
                             Address=t1.Address
                         }).FirstOrDefault();
            return View(album);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            string   id = form["OrderId"].ToString(); 
            var cc = db.Order.Find(id);
            if (ModelState.IsValid)
            {
                cc.Address = form["Address"].ToString();
                cc.Email = form["Email"].ToString();

                db.SaveChanges();
                return Content("<script>alert('修改成功！');window.open ('"
                    + Url.Content("~/Order/List") + "' ,'_self')</script>");
            }
            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", cc.LeiBieId);
            return View(form);
        }

        public ActionResult Delete(string id)
        {
            var order = db.Order.Find(id);
            return View(order);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, FormCollection collection)
        {
            var order = db.Order.Find(id);

            db.Order.Remove(order); db.SaveChanges();
            return Content("<script>alert('删除成功！');window.open ('"
                + Url.Content("~/Order/List") + "' ,'_self')</script>");
        }
    }

}