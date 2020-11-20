
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;



namespace Data.CustomConvention
{
    public class KeyConvention : Convention
    {
        public KeyConvention()
        {
            Properties<int>().Where(p => p.Name.EndsWith("code")).Configure(p=>p.IsKey());
        }
    }
}
