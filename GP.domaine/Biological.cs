using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Biological : Product
    {
        public string Herbs { get; set; }

        public override void GetMyType()
        {
            base.GetMyType();
            Console.WriteLine("BIOLOGICAL");
        }
    }
}
