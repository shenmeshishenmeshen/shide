using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Wedding.Models;

namespace Wedding.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        FlowersEntity db = new FlowersEntity();
        public ActionResult Index()
        {
            var movies = from m in db.User select m;
            return View(movies.ToList());
            
        }
    }
}