using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public Product(string name, int quantity, float price, string description, DateTime dateProd)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
            DateProd = dateProd;
        }
        public Product()
        {
            
        }
        public int ProducId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime DateProd { get; set; }
        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }
        public override string ToString()
        {
            return "Name: " + Name + "Quantity: " + Quantity + "Price: " + Price;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis un produit");
        }

    }
}
