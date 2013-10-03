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
        protected void Page_Load(object sender, EventArgs e)
        {

            //Getting all products with requested image 
            string choice = Request.QueryString["img"];
            Product[] allProducts = Data.SampleData();

            //Keeping the same quantity
            Dictionary<string, int> televisions = (Dictionary<string, int>)Session["cart"];

            //Enable User to keep using
            if (televisions[choice] == 3)
            {
                txtQuantWant.Text = "Out of Stock";
                txtQuantWant.Enabled = false;
            }

            //Setting the Basics
            televisions = setBasics(televisions, choice);

            //Setting the IMage and Description according to what the user wants
            setImage(allProducts, choice);

        }


        private void setImage(Product[] allProducts, string choice)
        {

            for (int i = 0; i < 10; i++)
            {
                if (choice == allProducts[i].Name)
                {
                    img_tv.ImageUrl = allProducts[i].URL;
                    var pathToFile = Server.MapPath(allProducts[i].Description);
                    lbldes.Text = File.ReadAllText(pathToFile);
                    lblprice.Text = string.Format("{0:C}", allProducts[i].Price);                   
                }

            }
        }

        private Dictionary<string, int> setBasics(Dictionary<string, int> televisions, string choice)
        {

            //Total items
            int total = 0;

            //Going through Dictionary to see how many items ordered
            foreach (var key in televisions.Keys)
            {
                int value = televisions[key];
                total = total + value;
            }

            //Update how many left
            int quantLeft = 3 - televisions[choice];
            lblquant.Text = string.Format("{0:0}", quantLeft);

            lblHowMuch.Text = ("You currently have " + total);

            return televisions;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string choice = Request.QueryString["img"];
            Dictionary<string, int> televisions = (Dictionary<string,int>)Session["cart"];

            if (televisions[choice] + int.Parse(txtQuantWant.Text) > 3)
            {
                txtQuantWant.Text = "Quantity to Little";
            }
            else
            {
                int quantwant = int.Parse(txtQuantWant.Text);
                televisions[choice] += quantwant;

                if (televisions[choice] == 3)
                {
                    txtQuantWant.Text = "Out of Stock";
                    txtQuantWant.Enabled = false;
                }
            }

            televisions = setBasics(televisions, choice);


            Session["cart"] = televisions;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> televisions; 
            
            televisions = new Dictionary<string, int>();
            string choice = Request.QueryString["img"];

            Product[] allProducts = Data.SampleData();

            for (int i = 0; i < 10; i++)
            {
                televisions.Add(allProducts[i].Name, 0);
            }

            txtQuantWant.Enabled = true;
            txtQuantWant.Text = "";
            lblquant.Text = string.Format("{0:0}", televisions[choice] + 3);
            lblHowMuch.Text = ("You currently have " + televisions[choice]);


            Session["cart"] = televisions; 
        }
    }
}