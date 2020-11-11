using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEF6
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        //public MyDBContext() : base("DefaultConnection") {}
        public MyDBContext() : base("server=localhost;User Id=root; Persist Security Info=True;database=ProductsDB;password=moh123")
        {
            if (!this.Database.Exists())
            {
                Console.WriteLine("DB not exists ... Creating DB");
                this.Database.Create();
                Console.WriteLine("DB created successfuly.");
            }

            Console.WriteLine("Initiating DB ...");
        }
    }

}
