using Domain;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data.CustomConvention;
using Data.Configurations;

namespace Data
{
    public class GpContext : DbContext 
    {
        public GpContext():base("name=Alias")
        {
                
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Add(new DateTypeConvention());
            modelBuilder.Conventions.Add(new KeyConvention());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new AdresseConfiguration());
           // modelBuilder.Entity<Chemical>().Map(ch => ch.ToTable("Chemicals").MapInheritedProperties());
           // modelBuilder.Entity<Biological>().Map(ch => ch.ToTable("Biologicals").MapInheritedProperties());



        }


    }
}
