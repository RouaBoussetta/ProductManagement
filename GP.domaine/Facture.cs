using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Domain;
namespace GP.domaine
{
    public class Facture
    {
        public DateTime DateAchat { get; set; }
        public int Quantity { get; set; }
        public Client Client { get; set; }
        [ForeignKey("Client")]
        [Key]
        [Column(Order =1)]
        public int ClientFK { get; set; }
        [ForeignKey("Product")]

        public int ProductFK { get; set; }

        public Product Product { get; set; }
    }
}
