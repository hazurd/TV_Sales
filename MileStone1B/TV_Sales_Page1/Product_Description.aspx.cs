using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TV_Sales_Page1
{
    public partial class Product_Description : System.Web.UI.Page
    {
        private Product theProduct;

        protected void Page_Load(object sender, EventArgs e)
        {

            //Getting all products with requested image 
            string choice = Request.QueryString["img"];

            TelevisionDbDataContext context = new TelevisionDbDataContext();
            var query = from p in context.Products
                        where p.Name == choice
                        select p;
            theProduct = query.Single();

            //Keeping the same Quantity Through Session
            Dictionary<string, int> televisions = (Dictionary<string, int>)Session["cart"];

            //Enable User to Keep Using Based On Stock
            if (televisions[choice] == theProduct.Quantity)
            {
                txtQuantWant.Text = "Out of Stock";
                txtQuantWant.Enabled = false;
            }

            //Setting the Basics
            televisions = setBasics(televisions);
            setImage();
        }

        //Updated Database Version
        private void setImage()
        {
            img_tv.ImageUrl = theProduct.ImageUrl;
            var pathToFile = Server.MapPath(theProduct.Description);
            lbldes.Text = File.ReadAllText(pathToFile);
            lblprice.Text = string.Format("{0:C}", theProduct.Price);                           
        }

        private Dictionary<string, int> setBasics(Dictionary<string, int> televisions)
        {
            //Total items
            int total = 0;

            //Going through Dictionary to see how many items ordered Total
            foreach (var key in televisions.Keys)
            {
                int value = televisions[key];
                total = total + value;
            }

            //Update how many left
            int quantLeft = (int)theProduct.Quantity - televisions[theProduct.Name];
            lblquant.Text = string.Format("{0:0}", quantLeft);

            lblHowMuch.Text = ("You currently have " + total);

            return televisions;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //Adding an Item to the Cart

            Dictionary<string, int> televisions = (Dictionary<string,int>)Session["cart"];

            if (televisions[theProduct.Name] + int.Parse(txtQuantWant.Text) > 3)
            {
                txtQuantWant.Text = "Quantity to Little";
            }
            else
            {
                int quantwant = int.Parse(txtQuantWant.Text);
                televisions[theProduct.Name] += quantwant;

                if (televisions[theProduct.Name] == 3)
                {
                    txtQuantWant.Text = "Out of Stock";
                    txtQuantWant.Enabled = false;
                }
            }

            televisions = setBasics(televisions);
            Session["cart"] = televisions;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Reset All Values Inside Dictionary

            Dictionary<string, int> televisions = new Dictionary<string, int>();
            TelevisionDbDataContext context = new TelevisionDbDataContext();

            var query = (from p in context.Products
                         select p.Name).ToList();

            List<string> names = new List<string>();
            names = query;

            for (int i = 0; i < names.Count; i++)
            {
                televisions.Add(names[i].Trim(), 0);
            }

            txtQuantWant.Enabled = true;
            txtQuantWant.Text = "";
            lblquant.Text = string.Format("{0:0}", televisions[theProduct.Name] + 3);
            lblHowMuch.Text = ("You currently have " + televisions[theProduct.Name]);

            Session["cart"] = televisions; 
        }
    }
}