using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext2())
            {

                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("\n\nAll blogs in the database:");
                foreach ( var item in query )
                {
                    Console.WriteLine("\n - "+item.Name);
                }

                Console.WriteLine("\n\nPress any key to exit");
                Console.ReadKey();
            }
        }
    }
}
