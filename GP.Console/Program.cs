using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "tomate";
            p1.DateProd = new DateTime(2020, 10, 01);
            Product p2 = new Product("pomme","sqkfjlkfj",12.5,DateTime.Now,16);
            Product p3 = new Product
            {

                Name = "pomme de terre",
                Description="produit frais"
                
            
                
            };


          //  System.Console.WriteLine("La liste des produits :");
          //  System.Console.WriteLine("Name="+p1.Name+"Date du produit="+p1.DateProd);
           // System.Console.WriteLine(p2);
           // System.Console.WriteLine(p3);

            Provider pr1 = new Provider();
            pr1.UserName = "Roua";
            pr1.Password = "56fdfdg";
            pr1.ConfirmPassword = "56fdfdg";
            pr1.Email = "roua@esprit.tn";
            pr1.DateCreation = DateTime.Now;
            pr1.IsApproved = true;


          //  System.Console.WriteLine("La liste des provider :");
          //  System.Console.WriteLine(pr1);
//System.Console.ReadKey();


            Provider pr2 = new Provider()
            {
                UserName = "4SAE2",
                Password = "jhkljlk"
            };

            Provider pr3 = new Provider()
            {
                Password = "abcde",
                ConfirmPassword = "abcde"
            };


            Biological b = new Biological();
            Chemical c = new Chemical();


            b.GetMyType();
            c.GetMyType();

            // Provider.SetIsApproved(pr3);
            Provider.SetIsApproved(pr3.Password,pr3.ConfirmPassword,pr3.IsApproved);
          System.Console.WriteLine(pr3.IsApproved);


            
            System.Console.ReadKey();


        }
    }
}
