using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;
using System.Dynamic;
using System.IO;
using PagedList;

namespace Wedding.Controllers
{
    public class ShangPing19manController : Controller
    {
        WeddingEntity db = new WeddingEntity();
        // GET: ShangPing19man
        //public ActionResult List(int id,int? page)
        //{
        //    var jihe = from r in db.ShangPin.Where(a=>a.LeiBieId== id) select r;
        //    int pageNumber = page ?? 1;
        //    jihe=jihe.OrderBy(a => a.ShangPinId);
        //    //第几页，有值就为值，没值就唯1；
        //    int pageSize = 24;
        //    IPagedList<ShangPin> pagedList = jihe.ToPagedList(pageNumber, pageSize);
        //    return View(pagedList);
        //}
        //[HttpPost]
        //public ActionResult List(FormCollection form ,int id)
        //{
        //    ViewBag.SearchText = form["s"];
        //    ViewBag.retu = "你搜索的结果:";
        //    string sText = form["s"].Trim();

        //    if (sText != "" || sText != null)
        //    {
        //        var changDi = db.ShangPin.Where(a => a.LeiBieId == id && a.Title.Contains(sText)).ToList();
        //        if (changDi.Count != 0)
        //        {
        //            return View(changDi);
        //        }
        //        else
        //        {
        //            ViewBag.SearchText = "没有你想要的结果……";
        //            var changdi = db.ShangPin.ToList();
        //            return RedirectToAction("LISTHE", "ShangPing19man");
        //        }
        //    }
        //    else
        //    {
        //        return Content("<script>alert('请输入你要搜索的关键字');window.open ('" + Url.Content("#") + "' ,'_self')</script>");
        //    }

        //}
        //public ActionResult LISTHE()
        //{
        //    var he = db.ShangPin.ToList();
        //    return View(he);
        //}
        public ActionResult PingJia(int id)
        {
            if (Session["UserName"] != null)
            {
                var shangpin = db.ShangPin.Find(id);
                return View(shangpin);
            }
            else
            {
                return RedirectToAction("Login", "Acount");
            }

        }
        [HttpPost]
        public ActionResult PingJia(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                if (collection["s"] == null || collection["s"] == "")
                {
                    return Content("<script>alert('请输入评论内容');window.open ('" + Url.Content("#") + "' ,'_self')</script>");
                }
                else
                {
                    PingJia pingjia = new PingJia();
                    pingjia.TuPian = collection["picimg"];
                    pingjia.DateTime = DateTime.Now;
                    pingjia.NeiRong = collection["s"];
                    db.PingJia.Add(pingjia);
                    db.SaveChanges();
                    //return Content(collection["picimg"]);
                    return Content("<script>alert('评价成功，感谢');window.open ('" + Url.Content("~/ShangPing19man/LISTHE") + "' ,'_self')</script>");
                }
            }
            else
            {
                return Content("<script>alert('评价失败');window.open ('" + Url.Content("#") + "' ,'_self')</script>");
            }

        }
        public ActionResult Uploadfile()
        {
            //上传文件
            HttpPostedFileBase img = Request.Files["btnfile"];
            string s = img.FileName;
            string fileExtension = Path.GetExtension(s);
            string path = "/Content/PingJiaImages/";
            if (Directory.Exists(Server.MapPath(path)) == false)//如果不存在就创建file文件夹
            {
                Directory.CreateDirectory(Server.MapPath(path));
            }
            string virpath = path + Guid.NewGuid() + fileExtension;
            img.SaveAs(Server.MapPath(virpath));


            return Content(virpath);
        }
        public ActionResult List(int id,int? page)
        {
            var ss2 = from s in db.ShangPin.OrderBy(p => p.ProuductId).Where(p => p.LeiBieId ==id) select s;
            int pageNumber = page ?? 1;
            //第几页，有值就为值，没值就唯1；
            int pageSize = 24;
            IPagedList<Prouduct> pagedList = ss2.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
        public ActionResult LISTHE(int? page )
        {
            var ss2 = from s in db.ShangPin.OrderBy(p => p.ProuductId) select s;
            int pageNumber = page ?? 1;
            //第几页，有值就为值，没值就唯1；
            int pageSize = 24;
            IPagedList<Prouduct> pagedList = ss2.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
    }
}