using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214081
{
    internal class Book_1214081 : Product_1214081
    {
        protected string pageCount;

        public Book_1214081(string type, string title, string pagecount) : base(type,title)
        {
            /*this.MyType = type;
            this.MyTitle = title;*/
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
