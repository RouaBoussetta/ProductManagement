using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Champ obligatoire")]  
        [StringLength(25,ErrorMessage ="Longueur maximale 25")]
        [MaxLength(50)]

        public string Name { get; set; }
        public DateTime DateProd { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Display(Name ="Production Data ")]
        public string Description { get; set; }
        [DataType(DataType.Currency)]

        public double Price { get; set; }
        
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }
        //[ForeignKey("categoryFK")]

        public Category category { get; set; }
        
        [ForeignKey("category")]
        public int? CategoryFK{ get; set; }
        public virtual ICollection<Provider> providers { get; set; }
        public string Image { get; set; }

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
