namespace TV_Sales_Page1
{
    partial class Product
    {

        public Product(string n, string desc, int q, string i, double p)
        {
            Name = n;
            Description = desc;
            Quantity = q;
            ImageUrl = i;
            Price = (decimal)p;
        }
    }
}
