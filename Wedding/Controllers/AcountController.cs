using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;
using System.Web.UI;
using System.Web.UI.WebControls;
using PageDemo.Models;

namespace Wedding.Controllers
{
    public class AcountController : Controller
    {
        // GET: Acount
        WeddingEntity db = new WeddingEntity();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection member)
        {
            string str = member["UserName"];
            string str1 = member["UserPwd"];
            var sum = (from r in db.User where r.UserName == str && r.UserPwd == str1 select r).FirstOrDefault();
            if (sum != null)
            {
                Session["UserName"] = str;
                Session["UserId"] = sum.UserID;
                return RedirectToAction("Index", "Home", Session["UserName"]);
            }
            else
                return Content("<script>alert('密码或账号错误！');window.open ('" + Url.Content("~/Acount/Login") + "' ,'_self')</script>");
        }
        public ActionResult Reg()
        {
            ViewBag.Sex = new List<SelectListItem>()
            {
                new SelectListItem(){ Value="男" ,Text="男"},
                new SelectListItem(){Value="女", Text="女"}
            };
            return View();
        }
        [HttpPost]
        public ActionResult Reg(FormCollection colltion)
        {
            
            if (ModelState.IsValid)
            {
                string username = colltion["UserName"].Trim();
                string userpwd = colltion["UserPwd"].Trim();


                string cnum = Session["ValidateCode"] == null ? "" : Session["ValidateCode"].ToString();

                if (colltion["coDE"].ToLower() != cnum.ToLower() && !string.IsNullOrEmpty(colltion["coDE"]))
                {
                    return Content("<script>alert('验证码不正确！');window.open ('" + Url.Content("~/Acount/Reg") + "' ,'_self')</script>");
                }

                    var sum = (from r in db.User where r.UserName == username select r).FirstOrDefault();
                var sum2 = (from r in db.Member where r.ManrName == username && r.ManPwd == userpwd select r).FirstOrDefault();
                if (sum != null || sum2 != null)
                {
                    return Content("<script>alert('用户名已存在！');window.open ('" + Url.Content("~/Acount/Reg") + "' ,'_self')</script>");
                }
                else
                {
                    User user = new User();
                    user.RegTime = DateTime.Now;
                    UpdateModel(user, colltion);
                    db.User.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Acount");
                }
            }
            else
            {
                return Content("<script>alert('注册异常！');window.open ('" + Url.Content("~/Acount/Reg") + "' ,'_self')</script>");

            }


        }
        public ActionResult UserDetail(string id)
        {
            var UserD = db.User.Where(g => g.UserName == id);
            return View(UserD);
        }

        public ActionResult LoginMan()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginMan(FormCollection member)
        {
            string str = member["ManrName"];string str1 = member["ManPwd"];
            var sum1 = (from r in db.User where r.UserName == str && r.UserPwd == str1 select r).FirstOrDefault();
            var ss1 = db.Member.Where(p => p.ManrName == str && p.ManPwd == str1).FirstOrDefault();
            if (sum1 != null){
                return Content("<script>alert('密码或账号错误！');window.open ('" +
                    Url.Content("~/Acount/LoginMan") + "' ,'_self')</script>");}
            if (ss1 != null){
                Session["ManrName"] = str;
                return RedirectToAction("Index", "WebMan19", Session["ManrName"]);}
            else
                return Content("<script>alert('密码或账号错误！');window.open ('"
                    + Url.Content("~/Acount/LoginMan") + "' ,'_self')</script>");}

        public ActionResult UserZhuXiao()
        {
            Session["UserName"] = null;
            return RedirectToAction("Index", "Home", Session["UserName"]);
        }
        public ActionResult EditUserImfor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditUserImfor(FormCollection UserD)
        {
            string u = UserD["UserName"];
            string e = UserD["Email"];
            var UserPwd = (from r in db.User where r.UserName == u && r.Email == e select r).FirstOrDefault();
            if (UserPwd != null)
            {
                Session["UserName"] = UserPwd.UserName;
                return RedirectToAction("EditUserImforagen", "Acount");
            }
            return View(UserD);
        }
        public ActionResult EditUserImforagen()
        {
            string u = Convert.ToString(Session["UserName"]);
            var cc = (from r in db.User where r.UserName == u select r).First();
            return View(cc);
        }
        [HttpPost]
        public ActionResult EditUserImforagen(FormCollection UserD)
        {
          
            string u = Convert.ToString(Session["UserName"]);
            var cc = (from r in db.User where r.UserName == u select r).First();
                if (ModelState.IsValid)
            {
                string UserName = UserD["UserName"].Trim();
                string Email = UserD["Email"].Trim();
                string Sex = UserD["Sex"].Trim();
                cc.UserName = UserName;
                cc.UserPwd = UserD["UserPwd"];
                cc.Email = Email;
                cc.Sex = Sex;
                db.SaveChanges();
                Session["UserName"] = null;
                return Content("<script>alert('修改成功！');window.open ('" + Url.Content("~/Acount/Login") + "' ,'_self')</script>");
            }
            else
                return Content("<script>alert('修改失败！');window.open ('" + Url.Content("~/Acount/EditUserImforagen") + "' ,'_self')</script>");
        }
        public ActionResult GetImg()
        {
            
            int width = 100;
            int height = 40;
            int fontsize = 20;
            string code = string.Empty;
            byte[] bytes = ValidateCode.CreateValidateGraphic(out code, 4, width, height, fontsize);
            Session["ValidateCode"] = code;
            return File(bytes, @"image/jpeg");
        }
    }
}