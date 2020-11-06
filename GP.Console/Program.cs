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


            Product p = new Product()
            {
                Name = "tomate",
                DateProd = new DateTime(2020, 10, 30),
                Price = 12,
                Quantity = 1


            };

            ServiceProduct sp = new ServiceProduct();
            sp.AddProduct(p);
            sp.Savechanges();

            Console.WriteLine("créer avec succès");
            System.Console.ReadKey();

        }


    }
}
