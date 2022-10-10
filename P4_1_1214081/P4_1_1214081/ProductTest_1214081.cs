using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214081
{
    internal class ProductTest_1214081
    {
        static void Main(string[] args)
        {
            /*Product_1214081 myProduct = new Product_1214081();
           
            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Book_1214081 product1 = new Book_1214081("Book", "C# Object Oriented Solution", "300");
            DVD_1214081 product2 = new DVD_1214081("Hulk", "118");

            //Console.WriteLine("\" the book {0} has {1} pages\"", produc1.MyTitle, produc1.PageCount);
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("");
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} time duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
