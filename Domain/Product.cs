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
            //les collections et les interfaces representatives en c sharp 
            //IEnumerable la plus simple et legere juste une methode pour parcourir la collection :
            //a chaque fois j ai une requete je vais la reourner dans Ienulerable pour des 
              //  raisons d'optimisation juste pour parcourir et afficher : les requetes
              //retournes par Linq ou lambda expression 
            //Icollection : herite de Ienumerable qui permet de faire les methodes  crud
            //exp les objets de navigations 
            //Ilist : ya des methodes suppementaires ( recherche avancée ) dont je ne vais pas avoir besoin pour 
            //les objets de navigation 
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public DateTime? DateProd { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
        public String Image { get; set; }

        public virtual ICollection<Provider> Providers { get; set; }
        
        // virtual va activer le lazy loading : chargement paresseux : ne ramene pas cette propriete 
        // emmene seulement les prop elementaires 
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
