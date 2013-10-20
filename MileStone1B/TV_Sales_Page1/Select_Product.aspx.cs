using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TV_Sales_Page1
{
    public partial class Select_Product : System.Web.UI.Page
    {
        private Product theProduct;

        protected void Page_Load(object sender, EventArgs e)
        {
            product_grid.DataSource = from Products in Data.SampleData()
                                 select Products;
            product_grid.DataBind();

            TelevisionDbDataContext context = new TelevisionDbDataContext();
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
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string test;

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