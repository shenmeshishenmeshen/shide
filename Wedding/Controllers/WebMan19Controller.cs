using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;
using System.IO;

namespace Wedding.Controllers
{
    public class WebMan19Controller : Controller
    {
        FlowersEntity db = new FlowersEntity();
        // GET: WebMan19
        public ActionResult Index()
        {
            var he = db.Prouduct.ToList();
            return View(he);
        }
        public ActionResult Uploadfile(int num)
        {
            string path="";
            switch (num)
            {
                case 1:path = "/Content/Flowers/";
                    break;
                case 2:
                    path = "/Content/yujin/";
                    break;
                case 3:
                    path = "/Content/Lily/";
                    break;

                case 4:
                    path = "/Content/Complex/";
                    break;
                case 5:
                    path = "/Content/Meaty/";
                    break;
                case 6:
                    path = "/Content/fruitTrees/";
                    break;
                case 7:
                    path = "/Content/green/";
                    break;
                case 8:
                    path = "/Content/Custom/";
                    break;
                default:;
                    break;
            }
            //上传文件
            HttpPostedFileBase img = Request.Files["btnfile"];
            string s = img.FileName;
            string fileExtension = Path.GetExtension(s);
            if (Directory.Exists(Server.MapPath(path)) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(Server.MapPath(path));
            }
            string virpath = path + Guid.NewGuid() + fileExtension;
            img.SaveAs(Server.MapPath(virpath));
            return Content(virpath);
        }
        public ActionResult Edit(int id)
        {
            var album = db.Prouduct.Find(id);

            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", album.LeiBieId);
            return View(album);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            int id = int.Parse(form["id"]); var cc = db.Prouduct.Find(id);
            if (ModelState.IsValid)
            {
                string jiaqian = form["Price"]; string jieshao = form["Title"]; string tupian = form["TuPian"];
                int leibeiID = Convert.ToInt32(form["LeiBieId"]);
                cc.Price = Convert.ToDecimal(jiaqian); cc.Title = jieshao; cc.TuPian = tupian; cc.LeiBieId = leibeiID;
                db.SaveChanges();
                return Content("<script>alert('修改成功！');window.open ('"
                    + Url.Content("~/WebMan19/Index") + "' ,'_self')</script>");
            }
            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", cc.LeiBieId);
            return View(form);
        }
        public ActionResult Details(int id)
        {
            var shangpin = db.Prouduct.Find(id);
            return View(shangpin);
        }

        public ActionResult Create()
        {
            Prouduct shangPin = new Prouduct();
            var SelectItems = new List<dynamic>(){
        new { IsNew ="Y", name="是"},
        new { IsNew ="N", name="否"}
    };
            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", shangPin.LeiBieId);
            ViewBag.IsNew= new SelectList(SelectItems, "IsNew", "name", shangPin.IsNew);

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            Prouduct shangPin = new Prouduct();
            if (ModelState.IsValid)
            {
                UpdateModel(shangPin, form);
                db.Prouduct.Add(shangPin); db.SaveChanges();
                return Content("<script>alert('添加成功！');window.open ('"
                    + Url.Content("~/WebMan19/Index") + "' ,'_self')</script>");
            }
            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", shangPin.LeiBieId);
            return View();
        }
        public ActionResult Delete(int id)
        {
            var shangPin = db.Prouduct.Find(id);
            ViewBag.LeiBieId = new SelectList(db.LeiBie, "LeiBieId", "Name", shangPin.LeiBieId);

            return View(shangPin);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var shangPin = db.Prouduct.Find(id);
            var sum = (from r in db.Order where r.ProuductId == id select r).FirstOrDefault();
            if (sum != null)
                return Content("<script>alert('该商品已被添加到订单，暂不能删除！');window.open ('"
                    + Url.Content("~/WebMan19/Index") + "' ,'_self')</script>");
            else
            {
                db.Prouduct.Remove(shangPin); db.SaveChanges();
                return Content("<script>alert('删除成功！');window.open ('"
                    + Url.Content("~/WebMan19/Index") + "' ,'_self')</script>");
            }
        }
        //public ActionResult SevView()
        //{
        //    int ss1;
        //    if (Session["ManrName"] == null)
        //    {
        //        return RedirectToAction("LoginMan", "Acount");
        //    }
        //    else
        //    {
        //        int uid = Convert.ToInt32(Session["UserId"]) + 100000;
        //        if (Session["UserId"] == null)
        //        {
        //            ss1 = 0;
        //        }
        //        else
        //        {
        //            ss1 = Convert.ToInt32(Session["UserId"]) + 100000;
        //        }
        //        string str = Convert.ToString(Session["ManrName"]);
        //        int menid = db.Member.Where(a => a.ManrName == str).FirstOrDefault().ManrID;
        //        var jihe = from s in db.SevTexts where s.TextId == ss1 || s.TextId == menid select s;
        //        return View(jihe);
        //    }
        //}

    }
}