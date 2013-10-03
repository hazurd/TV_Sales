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
        protected void Page_Load(object sender, EventArgs e)
        {

            Dictionary<string, int> televisions = (Dictionary<string, int>)Session["cart"];
            Product[] allProducts = Data.SampleData();

            decimal subTotal = 0;

            foreach (var key in televisions.Keys)
            {
                int i;
                for (i = 0; i < 10; i++)
                {
                    if (allProducts[i].Name == key)
                        break;
                }
                int value = televisions[key];

                if (value > 0)
                {
                    blList.Items.Add(key + " (" + value + " @" + allProducts[i].Price + " ): $" + (allProducts[i].Price * value));
                    subTotal += (decimal)(allProducts[i].Price * value);
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