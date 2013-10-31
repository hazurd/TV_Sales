using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace TV_Sales_Page1
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            //Getting all Names from database to List
            TelevisionDbDataContext context = new TelevisionDbDataContext();
            var query = (from p in context.Products
                        select p.Name).ToList();

            List<string> names = new List<string>();
            names = query;

            Dictionary<string, int> televisions = new Dictionary<string, int>();

            for (int i = 0; i < names.Count; i++)
            {
                televisions.Add(names[i].Trim(), 0);
            }

            Session["cart"] = televisions;
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
