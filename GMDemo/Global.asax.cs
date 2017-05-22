using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GMDemo
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AutoFacConfig.ConfigureContainer();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}