
using System;

namespace static_clss
{
     static class Product
    {
        public static int Productid;
        public static string Productname;
        public static int Productprice;

        static Product()
        {
            Productid=4564;
            Productname="hghg";
            Productprice=4500;
        }
        public static void getProductdetails()
        {
            Console.WriteLine("Product id is :{0}",Productid);
             Console.WriteLine("Product name is :{0}",Productname);
              Console.WriteLine("Product price is :{0}",Productprice);

        }
        class static_clss
        {
            static void Main(string[]  args)
            {
                Product.getProductdetails();
            }
        }

    }
}