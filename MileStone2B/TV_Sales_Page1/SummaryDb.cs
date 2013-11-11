namespace TV_Sales_Page1
{
    partial class SummaryDbDataContext
    {
    }

    partial class Summary
    {

        public Summary(string n, int o, string u,decimal st, decimal p, decimal g, decimal t, string d)
        {
            Username = u;
            OrderId = o;
            SubTotal = st;
            PST = p;
            GST = g;
            Total = t;
            OrderDate = d;

        }
    }
}
