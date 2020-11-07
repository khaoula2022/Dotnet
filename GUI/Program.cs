using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Services;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "biscuit";
            p1.DateProd = DateTime.Now;
            Product p2 = new Product("Dwide", 32, 500, "eat some dwide", new DateTime(2020, 10, 2));
            //initialiseur d'objet
            Product p3 = new Product { Name = "pomme", Quantity = 17  ,Price = 12, Description = "ok"  , DateProd = new DateTime(2020, 10, 2) };
            // Console.WriteLine(p3);

            ServicesProduct sp = new ServicesProduct();
            sp.AddProduct(p3);
            sp.SaveChanges();
            Console.WriteLine(" base genere ");
            Console.ReadKey();
        }
    }
}
/********
 *  Provider pr1 = new Provider { UserName ="username" ,Password ="abcdef" ,
                ConfirmPassword = "abcdef" , Email = "ayoub@gmail"

            };

            // Console.WriteLine(pr1.Login("username", "abcdeGf"));
            Chemical c = new Chemical();
            Biological b = new Biological();
            p2.GetMyType();
            c.GetMyType();
            b.GetMyType();
            Provider.SetIsApproved(pr1);
            Provider.SetIsApproved(pr1.Password,pr1.ConfirmPassword,pr1.IsApproved);
            Console.WriteLine(pr1.IsApproved);


            Provider prov = new Provider
            {
                UserName = "khalil",
                Password = "aaaaaa",
                ConfirmPassword = "aa",
                Email = "a"
            };
            prov.UpperName();
            Console.WriteLine(prov.UserName);












            Console.ReadKey();
            Category ct = new Category { CategoryId = 1 };
            p2.Category = ct;
            Console.WriteLine(p2.InCategory(ct));
        }
    }
**/
