using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;

namespace CustomisationService.Service
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
//            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Edit the base address of MyService by replacing the "MyService" string below
            RouteTable.Routes.Add(new ServiceRoute("service", new WebServiceHostFactory(), typeof(Communication)));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}