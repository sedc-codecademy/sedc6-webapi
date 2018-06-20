using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebApiValidation.Filters;

namespace WebApiValidation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //GlobalConfiguration.Configuration.Filters.Add(new ValidateModelAttribute(true));
            //GlobalConfiguration.Configuration.Filters.Add(new AuthorizeAttribute);
        }
    }
}
