using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214081
{
    public class Product_1214081
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;

        public Product_1214081()
        {

        }

        public Product_1214081(string type, string title) //method Constructor, Constructor ini memiliki 2 parameter
        {
            this.myType = type;
            this.myTitle = title;

        }       

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }

        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
