using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
   public class AdresseConfiguration :ComplexTypeConfiguration<Adresse>
    {
        public AdresseConfiguration()
        {
            Property(a => a.City).IsRequired().HasMaxLength(50);

        }

    }
}
