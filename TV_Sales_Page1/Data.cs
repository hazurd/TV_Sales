using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TV_Sales_Page1
{
    public class Product 
    {
		/* ======================================================================
		   Fields
		   ---------------------------------------------------------------------- */
        private string name;
        private string description;
        private int quantity;
        private string imageUrl;

		/* ======================================================================
		   Constructor(s)
		   ---------------------------------------------------------------------- */
        public Product(string n, string desc, int q, string i)
		{
            name = n;
            description = desc;
            quantity = q;
            imageUrl = i;
		}

		
		/* ======================================================================
		   Public interface (methods and properties)
		   ---------------------------------------------------------------------- */
        public string Name
        {
            get { return name; }
        }
    }

	/* `Data` is a "utility" class. You don't create instances of it:

    	   Data d = new Data(); // do not do this
	   
	   Instead, you can retrieve the sample data anywhere in your App using the call
	   to the SampleData() method directly from the `Data` class:
	   
	       Product[] allProducts = Data.SampleData();

       In this way its similar to the `Math` class's `Math.Sin()`, `Math.Abs()`, etc...
	   This is accomplished using the `static` keyword on both fields and methods.

	 */
    public class Data
    {
        private const int SIZE = 10;

        // store the sample data
        private static Product[] data;

        // A static constructor will called to initialize static fields.
        static Data()
        {
			// intialize the sample data
            data = new Product[SIZE];
            data[0] = new Product("Samsung", "Garbage", 3, "~/Images/Samsung.jpg");
            data[1] = new Product("LG", "Garbage", 3);
            data[2] = new Product("Sony", "Garbage", 3);
            data[3] = new Product("Panasonic", "Garbage", 3);
            data[4] = new Product("Vizio", "Garbage", 3);
            data[5] = new Product("Mitsubishi", "Garbage", 3);
            data[6] = new Product("Phillips", "Garbage", 3);
            data[7] = new Product("Toshiba", "Garbage", 3);
            data[8] = new Product("Sanyo", "Garbage", 3);
            data[9] = new Product("Sharp", "Garbage", 3);

       
        }

		// retrieve the sample data.
        public static Product[] SampleData()
        {
            return data;
        }
    }
}