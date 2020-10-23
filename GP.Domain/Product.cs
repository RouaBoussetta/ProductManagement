using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Double Price { get; set; }
        public DateTime DateProd { get; set; }
        public int Quantity { get; set; }

        public Category Category { get; set; }
        public List<Provider> Providers { get; set; }

        public Product(String name,String description,Double price,DateTime dateProd,int quantity)
        {

            Name = name;
            Description = description;
            Price = price;
            DateProd = dateProd;
            Quantity = quantity;
        }

        public Product()
        {
                
        }


        public override string ToString()
        {
            return "Name="+Name+" Description="+Description+" Price="+Price+" Date= "+DateProd+" Quantity"+Quantity;
        }


        public virtual void GetMyType()
        {
            Console.WriteLine("je suis un produit");
        }

    }
}
