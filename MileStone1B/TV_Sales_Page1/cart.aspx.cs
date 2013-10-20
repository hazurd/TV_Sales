using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TV_Sales_Page1
{
    public partial class cart : System.Web.UI.Page
    {
        private Product theProduct;

        protected void Page_Load(object sender, EventArgs e)
        {
            TelevisionDbDataContext context = new TelevisionDbDataContext();
            Dictionary<string, int> televisions = (Dictionary<string, int>)Session["cart"];

            decimal subTotal = 0;

            foreach (var key in televisions.Keys)
            {
               int value = televisions[key];

                //Checking to See if Quantity is greater than 0
                if (value > 0)
                {
                    var query = from p in context.Products
                                where p.Name == key
                                select p;
                    theProduct = query.Single();

                    blList.Items.Add(key + " (" + value + " @" + theProduct.Price + " ): $" + (theProduct.Price * value));
                    subTotal += (decimal)(theProduct.Price * value);
                }
            }

            decimal gst = (decimal)(0.05) * subTotal;
            decimal pst = (decimal)(0.1) * subTotal;

            lblSubTot.Text = string.Format("{0:C}", subTotal);
            lblGst.Text = string.Format("{0:C}", gst);
            lblPst.Text = string.Format("{0:C}", pst);
            lblTot.Text = string.Format("{0:C}", gst + pst + subTotal);   
            
        }
    }
}