﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;

namespace Wedding.Controllers
{
    public class UseMan19Controller : Controller
    {
        WeddingEntity db = new WeddingEntity();
        // GET: UseMan19
        public ActionResult Index()
        {
            var user = db.User.ToList();
            return View(user);
        }
        public ActionResult Edit(int id)
        {
            var user = db.User.Find(id);


            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            int id = int.Parse(form["UserID"]);
            var cc = db.User.Find(id);
            if (ModelState.IsValid)
            {
                string UserName = form["UserName"].Trim();string Email = form["Email"].Trim();
                DateTime RegTime =Convert.ToDateTime(form["RegTime"]);
         string  Sex = form["Sex"].Trim();cc.UserName = UserName;cc.UserPwd = form["UserPwd"];
                cc.Email = Email;cc.Sex = Sex;
                db.SaveChanges();
                return Content("<script>alert('修改成功！');window.open ('" + Url.Content("~/UseMan19/Index") 
                    + "' ,'_self')</script>");}
            return View(form); }
        public ActionResult Details(int id)
        {
            var user = db.User.Find(id);
            return View(user);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            User user = new User();
            if (ModelState.IsValid)
            {
                UpdateModel(user, form);
                db.User.Add(user);
                db.SaveChanges();
                return Content("<script>alert('添加成功！');window.open ('" + Url.Content("~/UseMan19/Index") + "' ,'_self')</script>");
            }

            return View(form);
        }
        public ActionResult Delete(int id)
        {
            var user = db.User.Find(id);


            return View(user);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var user = db.User.Find(id);
            var sum = (from r in db.Cart where r.UserID == id select r).FirstOrDefault();
            if (sum != null)
                return Content("<script>alert('删除失败，该用户正在操作购物车！');window.open ('" 
                    + Url.Content("~/UseMan19/Index") + "' ,'_self')</script>");
            db.User.Remove(user);db.SaveChanges();
            return Content("<script>alert('删除成功！');window.open ('" + Url.Content("~/UseMan19/Index") + "' ,'_self')</script>");
        }

    }
}
