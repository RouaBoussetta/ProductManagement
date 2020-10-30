using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProduct
    {
        public List<Product> Products { get; set; }
        Func<string, List<Product>> FindProduct;
        Action<Category> ScanProduct;
        public ServiceProduct()
        {
            FindProduct = c =>
             {
                 List<Product> lsp = new List<Product>();
                 /*foreach (Product p in Products)
                 {
                     if (p.Name.StartsWith(c))
                         lsp.Add(p);
                 }
                 return lsp;*/
                 return Products.Where(p => p.Name.StartsWith(c)).ToList();
                 
             };
            ScanProduct = c =>
            {
                List<Product> lsp = new List<Product>();
                lsp = Products.Where(p => p.category.CategoryId == c.CategoryId).ToList();
                foreach (Product p in lsp)
                {
                    Console.WriteLine(p);
                }
            };

        
        }
        public List<Chemical> Get5Chemical (double price){
            var req = from p in Products
                      where p.Price > price
                      orderby p.Price
                      select p;
            return req.OfType<Chemical>().Take(5).ToList();
        }

        public IEnumerable<Chemical> GetProductPrice(double price)
        {
            var req = from p in Products
                      where p.Price > price
                      orderby p.Price
                      select p;
            return req.OfType<Chemical>().Skip(2);
        }

        public double GetAveragePrice()
        {
            return Products.Average(p => p.Price);
        }

        public double GetMaxPrice()
        {
            return Products.Max(p => p.Price);
        }

        public int GetCountProduct(String s)
        {
            List<Chemical> ListC = Products.OfType<Chemical>().ToList();
            var req = from c in ListC
                      where c.City == s
                      select c;
            return req.Count();
        }

        public List<Chemical> GetChemicalCity()
        {
            List<Chemical> ListC = Products.OfType<Chemical>().ToList();
            var req = from c in ListC
                      orderby c.City descending
                      select c;

            //var req2 = ListC.OrderBy(c => c.City);
            return req.ToList();
        }

        public void GetChemicalGroupByCity()
        {
            var req = from c in Products.OfType<Chemical>()
                      orderby c.City
                      group c by c.City;
            foreach(var g in req)
            {
                Console.WriteLine(g.Key);
                foreach(Chemical c in g)
                {
                    Console.WriteLine(c);
                }
            }

                      
        }
    }
}
