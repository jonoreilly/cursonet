using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                while (true)
                {
                    Console.Write("Enter a name for your Blog: ");
                    var name = Console.ReadLine();

                    var blog = new Blog { Name = name };
                    db.Blogs.Add(blog);
                    db.SaveChanges();

                    var query = from b in db.Blogs
                                select b.Name;

                    Console.WriteLine("\n\nAll blogs in the database:");

                    foreach (var item in query)
                    {
                        Console.WriteLine("\n - " + item.ToString());
                    }

                    Console.WriteLine("\nPress any key to exit");
                    Console.ReadKey();

                    Console.Clear();
                }
            }
        }
    }
}
