using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214081
{
    internal class DVD_1214081 : Product_1214081
    {
        protected string duration;

        public DVD_1214081(string title, string duration)
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
