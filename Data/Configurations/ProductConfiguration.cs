using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            //* * configuration
            HasMany(p => p.providers).WithMany(pv => pv.Products)
                .Map(T => T
            .ToTable("Providings")
            .MapLeftKey("ProdId")
            .MapRightKey("ProvId"));

            // 0-1  *  Configuration
            HasOptional(p => p.category).WithMany(c => c.products)
                .HasForeignKey(pc => pc.CategoryFK)
                .WillCascadeOnDelete(true);

            //heritage tph configuration
             Map<Chemical>(ch => ch.Requires("isBiological").HasValue(0));
             Map<Biological>(b => b.Requires("isBiological").HasValue(1));

            // TPT configuration

           // Map<Chemical>(ch => ch.ToTable("Chemicals"));
           // Map<Biological>(b => b.ToTable("Biologicals"));


            //TPCT configuration
          //  Map<Chemical>(ch => ch.ToTable("Chemicals").MapInheritedProperties());
          //  Map<Biological>(b => b.ToTable("Biologicals").MapInheritedProperties());


        }

    }
}
