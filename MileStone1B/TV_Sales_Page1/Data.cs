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
        private double price;

		/* ======================================================================
		   Constructor(s)
		   ---------------------------------------------------------------------- */
        public Product(string n, string desc, int q, string i, double p)
		{
            name = n;
            description = desc;
            quantity = q;
            imageUrl = i;
            price = p;
		}

		
		/* ======================================================================
		   Public interface (methods and properties)
		   ---------------------------------------------------------------------- */
        public string Name
        {
            get { return name; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public string Description
        {
            get { return description; }
        }

        public double Price
        {
            get { return price; }
        }


        public string URL
        {
            get { return imageUrl; }
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
            data[0] = new Product("Samsung", "~/Descriptions/samsung.txt", 3, "~/Images/Samsung.jpg",470.32);
            data[1] = new Product("LG", "~/Descriptions/LG.txt", 3, "~/Images/LG.jpg",832.48);
            data[2] = new Product("Sony", "~/Descriptions/sony.txt", 3, "~/Images/sony-bravia-40.jpg",692.49);
            data[3] = new Product("Panasonic", "~/Descriptions/panasonic.txt", 3, "~/Images/Panasonic.jpg",642.49);
            data[4] = new Product("Vizio", "~/Descriptions/vizio.txt", 3, "~/Images/Vizio.jpg",454.60);
            data[5] = new Product("Mitsubishi", "~/Descriptions/mitsubishi.txt", 3, "~/Images/Mitsubishi.jpg",4997.99);
            data[6] = new Product("Phillips", "~/Descriptions/phillips.txt", 3, "~/Images/Phillips.jpg",522.49);
            data[7] = new Product("Toshiba", "~/Descriptions/toshiba.txt", 3, "~/Images/Toshiba.jpg",722.48);
            data[8] = new Product("Sanyo", "~/Descriptions/sanyo.txt", 3, "~/Images/Sanyo.jpg",560.64);
            data[9] = new Product("Sharp", "~/Descriptions/sharp.txt", 3, "~/Images/Sharp.jpg",442.47);
  
       }

		// retrieve the sample data.
        public static Product[] SampleData()
        {
            return data;
        }

    }
}