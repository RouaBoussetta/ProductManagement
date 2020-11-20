
using System.Data.Entity.ModelConfiguration.Conventions;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace Data.CustomConvention
{
    public class DateTypeConvention : Convention
    {
        public DateTypeConvention()
        {
            Properties<DateTime>().Configure(p => p.HasColumnType("DateTime2"));

        }

    }
}
