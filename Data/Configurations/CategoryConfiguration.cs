using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using Domain;

namespace Data.Configurations
{
   public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {

        public CategoryConfiguration()
        {
            ToTable("MyCategories");
            HasKey(c => c.CategoryId);
            Property(c => c.Name).HasMaxLength(50);

            //0-1 to * configuration

            HasMany(c => c.products).WithOptional(p => p.category)
                .HasForeignKey(cp => cp.CategoryFK)
                .WillCascadeOnDelete(true);

                }

        
    }
}
