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
            List<string> names = null;


            List<Product> queryAsList = (List<Product>)Cache["Product_Query"];
            if (queryAsList == null)
            {
                // cache miss ($$$)
                var pSource = (from Products in context.Products
                               select Products);

                 var query = (from p in context.Products
                              select p.Name).ToList();

                 names = query;

                List<Product> pList = pSource.ToList();

                product_grid.DataSource = pSource;
                product_grid.DataBind();

                Cache.Insert("Product_Query", pList, null, DateTime.UtcNow.AddMinutes(10), Cache.NoSlidingExpiration);
            }
            else
            {
                // cache hit

                product_grid.DataSource = Cache["Product_Query"];
                product_grid.DataBind();
            }
            
            if (!IsPostBack)
            {
                //Place all products in the drop down menu
                for (int i = 0; i < names.Count; i++)
                {
                    ddlTvChoice.Items.Add(names[i].Trim()); 
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void product_grid_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            product_grid.PageIndex = e.NewPageIndex;

            TelevisionDbDataContext context = new TelevisionDbDataContext();

            List<Product> queryAsList = (List<Product>)Cache["Product_Query"];
            if (queryAsList == null)
            {
                // cache miss ($$$)
                var pSource = (from Products in context.Products
                                          select Products);

                List<Product> pList = pSource.ToList();

                product_grid.DataSource = pSource;
                product_grid.DataBind();

                Cache.Insert("Product_Query", pList, null, DateTime.UtcNow.AddMinutes(10), Cache.NoSlidingExpiration);
            }
            else
            {
                // cache hit

                product_grid.DataSource = Cache["Product_Query"];
                product_grid.DataBind();
            }

            // HERE: bar is initialized either way
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