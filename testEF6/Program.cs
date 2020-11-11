using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDBContext mdb = new MyDBContext();
            Product p = new Product { id = 0, name = "DOVE", description = "Good quality soap", price = 50 };
            mdb.Products.Add(p);
            mdb.SaveChanges();
        }
    }
}
