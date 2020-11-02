using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServicesProduct
    {
        public List<Product> listProdcuts = new List<Product>();
        public Func<string, List<Product>> FindProduct;
        public Action<Category> ScanProduct;
        public ServicesProduct()
        {
            ScanProduct = categ =>
            {


                foreach (Product product in listProdcuts)
                {
                    if (product.Category.CategoryId == categ.CategoryId)
                    {
                        Console.WriteLine(product);
                    }
                }
                listProdcuts.Where(p => p.Category.CategoryId == categ.CategoryId);
            };


            FindProduct = c =>
            {
                List<Product> lst = new List<Product>();
                foreach (Product p in listProdcuts)

                    if (p.Name.StartsWith(c))
                        lst.Add(p);
                return lst;
            };
        }

        public IEnumerable<Chemical> Get5Chemical(double price)
        {
            var req = from p in listProdcuts
                      where p.Price > price
                      select p;
            return req.Take(5).OfType<Chemical>();

            //Ignorer les deux promiers produits:
            //return req.Skip(2).OfType<Chamical>();
        }

        public double GetAveragePrice()
        {
            return listProdcuts.Average(p => p.Price);
        }
        public double GetMaxPrice()
        {
            return listProdcuts.Max(p => p.Price);
            //var req = from p in listProdcuts
            //          select p.Price;
            //return req.Max();
        }
        public int GetCountProduct(string city)
        {
            var req = from ch in listProdcuts.OfType<Chemical>()
                      where ch.City.Equals(city)
                      select ch;
            return req.Count();
        }
        public IEnumerable<Chemical> GetChemicalCity()
        {
            var req = from ch in listProdcuts.OfType<Chemical>()
                      orderby ch.City
                      select ch;
            return req;
            //Lambda
            //var req2 = listProdcuts.OfType<Chamical>().OrderBy(ch => ch.City);
        }

        public IEnumerable<IGrouping<string, Chemical>> GetChemicalGroupByCity()
        {
            var req = from ch in listProdcuts.OfType<Chemical>()
                      orderby ch.City
                      group ch by ch.City;

            //Afficher chaque group en plus de ces elements
            foreach (var group in req)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }

            return req;
            //Lambda
            //var req2 = listProdcuts.OfType<Chamical>()
            //    .OrderByDescending(ch => ch.City)
            //    .GroupBy(ch => ch.City);
            //return req2;

        }
    }
}