using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Transactions;

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

            List<CartItem> cartList = new List<CartItem>();

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


                    CartItem cartitems = new CartItem(theProduct.Name, (decimal)theProduct.Price, (decimal)(theProduct.Price * value), value);
                    cartList.Add(cartitems);
                }
            }

            gv_cart.DataSource = cartList;
            gv_cart.DataBind();

            decimal gst = (decimal)(0.05) * subTotal;
            decimal pst = (decimal)(0.1) * subTotal;

            lblSubTot.Text = string.Format("{0:C}", subTotal);
            lblGst.Text = string.Format("{0:C}", gst);
            lblPst.Text = string.Format("{0:C}", pst);
            lblTot.Text = string.Format("{0:C}", gst + pst + subTotal);   
            
        }

        protected void btn_purchase_Click(object sender, EventArgs e)
        {
            TelevisionDbDataContext context = new TelevisionDbDataContext();
            Dictionary<string, int> televisions = (Dictionary<string, int>)Session["cart"];

            
            using (TransactionScope cartTrans = new TransactionScope())
            {
                try
                {
                    //Updating the Database
                    foreach (var key in televisions.Keys)
                    {
                        int value = televisions[key];

                        //Checking to See if Quantity in cart is greater than 0
                        if (value > 0)
                        {

                            var query = from p in context.Products
                                        where p.Name == key
                                        select p;
                            theProduct = query.Single();

                            theProduct.Quantity = theProduct.Quantity - televisions[key];
                            context.SubmitChanges();

                        }
                    }
                    var nameList = (from p in context.Products
                                    select p.Name).ToList();

                    List<string> names = new List<string>();
                    names = nameList;

                    televisions = new Dictionary<string, int>();

                    for (int i = 0; i < names.Count; i++)
                    {
                        televisions.Add(names[i].Trim(), 0);
                    }

                    Session["cart"] = televisions;

                    Response.Redirect("~/ThankYou.aspx",false);

                    cartTrans.Complete();
                }
                catch (Exception E)
                {
                    cartTrans.Dispose();
                    Response.Redirect("~/ErrorPage.aspx?err=" + E.Message);
                }
            }
        }
    }
}