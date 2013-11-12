using System;
namespace TV_Sales_Page1
{
    partial class SummaryDbDataContext
    {
    }

    partial class Summary
    {

        public Summary(string n, int o, string u,decimal st, decimal p, decimal g, decimal t, DateTime d, 
            string fn, string ln, string ad, string c, char pr, char pc, int pn, string em)
        {
            Username = u;
            OrderId = o;
            SubTotal = (decimal)st;
            PST = (decimal)p;
            GST = (decimal)g;
            Total = (decimal)t;
            OrderDate = d;

            FirstName = fn;
            LastName = ln;
            Address = ad;
            City = c;
            Province = pr;
            PostalCode = pc;
            Phone = pn;
            Email = em;

        }
    }
}
