using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Provider:Concept
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        //  public string Password { get; set; }
        private String password;
        public String Password
        {
            get { return password; }
            set { if (value.Length < 5 || value.Length > 20)
                    Console.WriteLine("erreur de password");
                else password = value;
            }

        }
        public override string ToString()
        {
            return "id: " + Id + "userName: " + UserName;
        }
        private string confirmPassword;
        public String ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                if (!value.Equals(Password))
                    Console.WriteLine("erreur de Confirme password");
                else confirmPassword = value;
            }

        }
      //  public string ConfirmPassword { get; set; }
        public Boolean IsApproved { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public virtual ICollection  <Product> Products { get; set; }
        //public Boolean Login(string username , string password)
        //{
        //    // if(UserName.Equals(username)&& Password.Equals(password))
        //    return (string.Compare(UserName, username) == 0 && string.Compare(Password, password) == 0);
              
        //}
        //public Boolean Login(string username, string password, string email)
        //{
        //    return (string.Compare(UserName, username) == 0 && string.Compare(Password, password) == 0 && string.Compare(Email, email) == 0);

        //}
        public Boolean Login(string username, string password, string email=null)
        {
            return string.Compare(UserName, username) == 0
                && string.Compare(Password, password) == 0
                && email != null ? string.Compare(Email, email)==0 : true;


        }
        public static void SetIsApproved(Provider p) {
            p.IsApproved = p.password.Equals(p.confirmPassword);
        }
        public static void SetIsApproved(string password , string confirmpassword , Boolean isapproved)
        {
            isapproved = password.Equals(confirmpassword);
        }

        public override void GetDetail()
        {

            //Console.WriteLine("name="+Name);   
            //for (int i = 0; i < Products.Count; i++)
            //{
            //    Console.WriteLine(Products.ElementAt(i));
            //}
            foreach (Product p in Products)
            {
                Console.WriteLine(p);
            }
        }
       public void GetProducts(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Name": 
                    foreach (Product p in Products)                  
                       if (p.Name == filterValue)                      
                            Console.WriteLine(p);
                    break;
                case "DateProd":
                    foreach(Product p in Products)
                        if(p.DateProd == DateTime.Parse(filterValue))
                            Console.WriteLine(p);
                    break;
                case "Price":
                    foreach (Product p in Products)
                        if (p.Price == float.Parse(filterValue))
                            Console.WriteLine(p);
                    break;
            }
        }

    }
}
