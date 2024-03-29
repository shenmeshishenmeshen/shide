﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;
using System.Dynamic;
using Wedding.ViewModels;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;//json解析用
using System.IO;
using System.Net;
using PagedList;

namespace Wedding.Controllers
{
    public class HomeController : Controller
    {
        const String KEY = "f8abfbc6cf7244d195a3e8891bb04837";

        WeddingEntity db = new WeddingEntity();
        // GET: Home
        public ActionResult Index()
        {
      //(Session["UserName"] != null)
            //{

            //}
            var hunsha = (from s in db.ShangPin where s.LeiBieId == 1 orderby s.ProuductId descending select s).Take(4).ToList();

            return View(hunsha);
        }
        [ChildActionOnly]
        public ActionResult LUNbo()
        {
            var hunsha = (from s in db.ShangPin where s.LeiBieId == 1 orderby s.ProuductId descending select s).Take(3).ToList();
            return PartialView(hunsha);
        }
        public ActionResult NewProd(int? page)
        {
            var ss2 = from s in db.ShangPin.OrderBy(p => p.ProuductId).Where(p => p.ProuductId > 0) select s;
            int pageNumber = page ?? 1;
            //第几页，有值就为值，没值就唯1；
            int pageSize = 24;
            IPagedList<Prouduct> pagedList = ss2.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }

      
        public ActionResult Serch(FormCollection form, int? page)
        {
            ViewBag.SearchText = form["s"]; ViewBag.retu = "你搜索的结果:";
            string sText = form["s"].Trim();
            if (sText != "" || sText != null){
                var Result = from s in db.ShangPin.OrderBy
                             (p => p.ProuductId).Where(p => p.Title.Contains(sText) || p.LeiBie.Name.Contains(sText))
                             select s;
                if (Result.Count() == 0){
                    ViewBag.SearchText = "没有你想要的结果……";
                    Result = from s in db.ShangPin.OrderBy(p => p.ProuductId) select s;}
                int pageNumber = page ?? 1;int pageSize = 24;
                IPagedList<Prouduct> pagedList = Result.ToPagedList(pageNumber, pageSize);
                return View(pagedList);}
            else
                return Content("<script>alert('请输入你要搜索的关键字');window.open ('" + 
                    Url.Content("#") + "' ,'_self')</script>"); }
        [ChildActionOnly]
        public ActionResult Xzhu()
        {
            var xizhuang = (from s in db.ShangPin where s.LeiBieId == 2 orderby s.ProuductId descending select s).Take(4).ToList();

            return PartialView(xizhuang);
        }
        public ActionResult XiangQing(int id)
        {
            var hunsha = db.ShangPin.Find(id);
            return View(hunsha);
        }
        public ActionResult LiJiGouMai(int id)
        {
            if (Session["UserName"] != null)
            {
                var hunsha = db.ShangPin.Find(id);
                return View(hunsha);
            }
            else
                return RedirectToAction("Login", "Acount");

        }
        [ChildActionOnly]
        public ActionResult Hunche(int? page)
        {
            var hunche = from s in db.ShangPin where s.LeiBieId == 4 orderby s.ProuductId descending select s;
            int pageNumber = page ?? 1;
            //第几页，有值就为值，没值就唯1；
            int pageSize = 24;
            IPagedList<Prouduct> pagedList = hunche.ToPagedList(pageNumber, pageSize);
            return View(pagedList);
        }
        [ChildActionOnly]
        public ActionResult Changdi()
        {
            var changdi = (from s in db.ShangPin where s.LeiBieId == 3 orderby s.ProuductId descending select s).Take(4).ToList();


            return PartialView(changdi);
        }
        [ChildActionOnly]
        public ActionResult LeiBie()
        {
            var changdi = db.LeiBie.ToList();


            return PartialView(changdi);
        }
     
        //public ActionResult Servicer1(string input1)
        //{
        //    string input = input1;
        //    string url = "http://www.tuling123.com/openapi/api?key=" + KEY + "&info=" + input;
        //    Encoding encoding = Encoding.GetEncoding("utf-8");
        //    String data = HttpGet(url, encoding);
        //    JsonReader reader = new JsonTextReader(new StringReader(data));
        //    while (reader.Read())
        //    {                //tbxHistory.AppendText(reader.TokenType + "\t\t" + reader.ValueType + "\t\t" + reader.Value + "\n");               
        //        if (reader.TokenType == JsonToken.PropertyName
        //            && reader.ValueType == Type.GetType("System.String")
        //            && Convert.ToString(reader.Value) == "code")
        //        {
        //            /* 如果当前Value是code，读取下一条，查看code的值 */
        //            reader.Read();
        //            switch (Convert.ToInt32(reader.Value))
        //            {
        //                case 100000:                            /* 返回码为文本类数据 */
        //                    reader.Read();
        //                    reader.Read();
        //                    input = (string)reader.Value;
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //    }
        //    return Content(input);
        //}
        public static string HttpGet(string url, Encoding encoding)
        {
            string data = "";
            try
            {
                WebRequest request; //使用url发出请求的类               
                request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;   //使用默认的身份验证                
                request.Timeout = 10000;    //设定超时               
                WebResponse response;   //提供响应的类                
                response = request.GetResponse();
                data = new StreamReader(response.GetResponseStream(), encoding).ReadToEnd();    //获取数据           
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        public ActionResult HomeSevView()
        {
            int ss1;
            if (Session["UserName"] == null)
            {
                return RedirectToAction("Login", "Acount");
            }
            else
            {
                int uid = Convert.ToInt32(Session["UserId"]) + 100000;
                if (Session["ManrName"] == null)
                {
                    ss1 = 1;
                }
                else
                {
                    string str = Convert.ToString(Session["ManrName"]);
                    ss1 = db.Member.Where(a => a.ManrName == str).FirstOrDefault().ManrID;
                }
                var jihe = from s in db.SevTexts where s.TextId == uid || s.TextId == ss1 || s.Id == 1 select s;
                return View(jihe);

            }

        }
        public void TalekFun(string input1)
        {
            SevText sevText = new SevText();
            int str = Convert.ToInt32(Session["UserId"]) + 100000;
            sevText.TextId = str;
            sevText.Text = input1;
            sevText.TakeDatetime = DateTime.Now;
            db.SevTexts.Add(sevText);
            db.SaveChanges();
        }
        public ActionResult Thank()
        {
            return View();
        }
        public ActionResult Sugect()
        {
                return View();
        }
    }
}