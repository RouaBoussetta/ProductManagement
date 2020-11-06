using Data;
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

        public GpContext ctx = new GpContext();
        public void AddProduct(Product p)
        {
            ctx.Products.Add(p);
            
            
        }

        public void Savechanges()
        {
            ctx.SaveChanges();
        }

    }
}
