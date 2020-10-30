using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category category { get; set; }
        public List<Provider> providers { get; set; }

        public Product(string name, DateTime dateProd, string description, double price, int quantity)
        {
            Name = name;
            DateProd = dateProd;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return "Nameg= " +Name+ ", DateProd= "+ DateProd+ ", Description= "+Description+ ", Quantity= "+Quantity ;
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("Je suis un produit: ");
        }
    }
}
