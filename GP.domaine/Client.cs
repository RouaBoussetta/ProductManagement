using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GP.domaine
{
    public class Client
    {
        [Key]
        
        public int  Cin { get; set; }
        public String Nom { get; set; }
        public String prenom { get; set; }
        public ICollection<Facture> Factures { get; set; }
    }
}
