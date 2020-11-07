using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProvider
    {
       
    }
}

/***********
 *  public List<Provider> listProviders = new List<Provider>();

        public List<Provider> GetProviderByName(string name)
        {
            var req = from p in listProviders
                      where p.UserName.Contains(name)
                      select p;
            return req.ToList();
            //Avec Lambda
            //var req2 = listProviders.Where(p => p.UserName.Contains(name)).ToList();
            //return req2;
        }

        public Provider GetFirstProviderByName(string name)
        {
            var req = from p in listProviders
                      where p.UserName.StartsWith(name)
                      select p;
            return req.First();


        }

        //Afficher le nom et l'email des providers
        public void AfficherProvidersByName(string name)
        {
            var req = from p in listProviders
                      where p.UserName == name
                      select new { N = p.UserName, E = p.Email };
            foreach (var item in req)
            {
                Console.WriteLine($"name= {item.N} Email={item.E}");
            }
        }*/