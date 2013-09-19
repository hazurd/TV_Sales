using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TV_Sales_Page1
{
    public partial class TV_Choice : System.Web.UI.Page
    {
        public string url = " ";

        protected void Page_Load(object sender, EventArgs e)
        {

            string choice = Request.QueryString["choice"];
            //string url;

            if (!IsPostBack)
            {
                Product[] allProducts = Data.SampleData();
                ddlTvChoice.Items.Add(allProducts[0].Name);

               /* ddlTvChoice.Items.Add("Samsung");
                ddlTvChoice.Items.Add("LG");
                ddlTvChoice.Items.Add("Sony");
                ddlTvChoice.Items.Add("Panasonic");
                ddlTvChoice.Items.Add("Vizio");
                ddlTvChoice.Items.Add("Sharp");
                ddlTvChoice.Items.Add("Mitsubishi");
                ddlTvChoice.Items.Add("Phillips");
                ddlTvChoice.Items.Add("Toshiba");
                ddlTvChoice.Items.Add("Sanyo");*/

                lblStock.Text = "3";
            }

            switch (choice)
            {
                case "Samsung":
                    txtCheck.Text = "It works";
                    url = "~/Images/Samsung.jpg";
                    break;
                case "LG":
                    url = "~/Images/LG.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sony":
                    url = "~/Images/sony-bravia-40.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Panasonic":
                    url = "~/Images/Panasonic.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Vizio":
                    url = "~/Images/Vizio.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sharp":
                    url = "~/Images/Sharp.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Mitsubishi":
                    url = "~/Images/Mitsubishi.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Phillips":
                    url = "~/Images/Phillips.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Toshiba":
                    url = "~/Images/Toshiba.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sanyo":
                    url = "~/Images/Sanyo.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                default :
                    url = "~/Images/Pick.jpg";
                    txtCheck.Text = "Thinking";
                    break;
            }

            imgTV.ImageUrl = url;
            imgTV.Visible = true;
        }

        private void setImage()
        {
            //string url = "~/Images/sony-bravia-40.jpg";

            switch (ddlTvChoice.SelectedItem.Text)
            {
                case "Samsung":
                    txtCheck.Text = "It works";
                    url = "~/Images/Samsung.jpg";
                    break;
                case "LG":
                    url = "~/Images/LG.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sony":
                    url = "~/Images/sony-bravia-40.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Panasonic":
                    url = "~/Images/Panasonic.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Vizio":
                    url = "~/Images/Vizio.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sharp":
                    url = "~/Images/Sharp.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Mitsubishi":
                    url = "~/Images/Mitsubishi.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Phillips":
                    url = "~/Images/Phillips.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Toshiba":
                    url = "~/Images/Toshiba.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                case "Sanyo":
                    url = "~/Images/Sanyo.jpg";
                    txtCheck.Text = "Youre Retarded";
                    break;
                default:
                    url = "~/Images/Pick.jpg";
                    txtCheck.Text = "Thinking";
                    break;
            }

            imgTV.ImageUrl = url;
            imgTV.Visible = true;
        }


        protected void ddlTvChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            setImage();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            double update;
            double.TryParse(lblStock.Text, out update);

            if (update != 0)
                update--;
            if (update == 0) 
            {
                lblStock.Enabled = false;
                imgOutOfStock.Visible = true;
            }



            lblStock.Text = update.ToString();
        }
    }
}