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
                var total = db.Order.Where(a => a.Username == userName).Sum(a => a.Total);
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
                             LeiBie=t2.LeiBie.Name
                         }).ToList();
            return View(query);
        }

        public ActionResult Edit(int id)
        {
            var album = db.Order.Find(id);
            return View(album);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            string   id = form["id"]; 
            var cc = db.Order.Find(id);
            if (ModelState.IsValid)
            {
                string jiaqian = form["Price"];
                string jieshao = form["Title"];
                string tupian = form["TuPian"];
                int leibeiID = Convert.ToInt32(form["LeiBieId"]);
                cc.Price = Convert.ToDecimal(jiaqian); 
                cc.Title = jieshao;
                cc.TuPian = tupian; 
                cc.LeiBieId = leibeiID;
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