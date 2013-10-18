using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TV_Sales_Page1
{
    public partial class Select_Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}