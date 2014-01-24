using System.Web;
using System.Web.Http;


namespace MvcEmptyApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {


            // Add these two lines to initialize Routes and Filters:
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}