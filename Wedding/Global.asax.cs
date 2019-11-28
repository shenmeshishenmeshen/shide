using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Wedding.Models;

namespace Wedding
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer<WeddingEntity>(new Wedding.Models.SampleData());
            Database.SetInitializer<FlowersEntity>(new DropCreateDatabaseIfModelChanges<FlowersEntity>());
            Database.SetInitializer<FlowersEntity>(new Wedding.Models.SampleData());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
