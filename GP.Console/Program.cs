using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Category ct = new Category {
                Name = "Légumes"
        };
            Product p1 = new Product();
            p1.Name = "Tomate";
            p1.DateProd = new DateTime(2020, 10, 01);
            p1.category = ct;
            Console.WriteLine("Test cat: "+ p1.InCategory(ct) ); 
            Product p2 = new Product("pomme", DateTime.Now, "Bonne état", 12.14, 15);

            Product p3 = new Product() { 
                Name = "pomme de terre" ,
                Price=15.2,
                Description="en promotion"};

            System.Console.WriteLine("la list des produits: ");
            System.Console.WriteLine("Name: " + p1.Name + ", Date de production: " + p1.DateProd);
            System.Console.WriteLine(p2);
            System.Console.WriteLine(p3);

            Provider pr1 = new Provider() 
            {
                UserName = "Yasmine",
                Password = "000000000",
                ConfirmPassword = "00000kl",
                Email = "yasmine@gmail.com"
            };

            Provider pr2 = new Provider()
            {
                UserName = "Khalil",
                Password = "azerty",
                ConfirmPassword = "azerty",
                IsApproved = true
            };

            pr1.UpperName();
            Console.WriteLine(pr1.UserName);

            System.Console.WriteLine("La list des providers: ");
            System.Console.WriteLine(pr1);
            System.Console.WriteLine(pr2);

            Biological b = new Biological();
            Chemical c = new Chemical();

            b.GetMyType();
            c.GetMyType();

            Console.WriteLine("1ére M:");
            Provider.SetIsApproved(pr2);
            Console.WriteLine(pr2.IsApproved);

            Console.WriteLine("2éme M:");
            Provider.SetIsApproved(pr1.Password, pr1.ConfirmPassword, pr1.IsApproved);
            Console.WriteLine(pr1.IsApproved);

            System.Console.ReadKey();

        }


    }
}
