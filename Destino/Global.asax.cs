using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Destino
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object BundleConfig { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
           
        }
    }
}
