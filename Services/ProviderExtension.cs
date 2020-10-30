using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ProviderExtension
    {
        public static void UpperName(this Provider p)
        {
            p.UserName=p.UserName.ToUpper();
        }

        public static bool InCategory(this Product p, Category c)
        {
            return p.category.Name.Equals(c.Name);
        }
    }
}
