using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Caching;

namespace TV_Sales_Page1
{
    public partial class Select_Product : System.Web.UI.Page
    {
        private Product theProduct;

        protected void Page_Load(object sender, EventArgs e)
        {
            TelevisionDbDataContext context = new TelevisionDbDataContext();

            product_grid.DataSource = from Products in context.Products
                                      select Products;
            product_grid.DataBind();

            var query = (from p in context.Products
                         select p.Name).ToList();

            List<string> names = new List<string>();
            names = query;

            if (!IsPostBack)
            {
                //Place all products in the drop down menu
                for (int i = 0; i < names.Count; i++)
                {
                    ddlTvChoice.Items.Add(names[i].Trim()); 
                }
            }

            string bar = (string)Cache["foo"];
            if (bar == null)
            {
                // cache miss ($$$)
                bar = "bar";
                Cache.Insert("foo", bar, null, DateTime.Now.AddMinutes(123), Cache.NoSlidingExpiration);
               
            }
            else
            {
                // cache hit
            }

            // HERE: bar is initialized either way

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void product_grid_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            product_grid.PageIndex = e.NewPageIndex;

            TelevisionDbDataContext context = new TelevisionDbDataContext();

            Trace.Write("dev", "Before query");

            product_grid.DataSource = from Products in context.Products
                                select Products;
                                     
            product_grid.DataBind();
            Trace.Write("dev", "After query");
        }

        protected void btn_go_Click(object sender, EventArgs e)
        {
            string product = "";
            product = ddlTvChoice.SelectedItem.Text;
            
            //Response.Redirect("http://localhost:29103/Product_Description.aspx?img=" + product);

            Response.Redirect("~/Product_Description.aspx?img=" + product);
            
        }

        public string DecriptionUrl(string theName)
        {
            string description;

            TelevisionDbDataContext context = new TelevisionDbDataContext();
            var query = from p in context.Products
                        where p.Name == theName
                        select p;
            theProduct = query.Single();


            var pathToFile = Server.MapPath(theProduct.Description);

            description = File.ReadAllText(pathToFile);
            description = description.Substring(0, 50);
            description += "...";
            return(description);  
        }
    }
}