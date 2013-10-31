using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TV_Sales_Page1
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tv_Grid.DataSource = from Products in Data.SampleData()
                                 select Products;
            Tv_Grid.DataBind();

        }

        protected void Tv_Grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}