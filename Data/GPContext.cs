using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Data
{
  public   class GPContext : DbContext

    {
        public GPContext() : base("name=Alias")
        {
            //serveur bdd embarqué sql server est dej ainstallé avec vs

        }

        public DbSet <Product> Products  { get; set; }
         public DbSet<Category> Categories  { get; set; }
         public DbSet<Provider> Providers  { get; set; }


    }
}
