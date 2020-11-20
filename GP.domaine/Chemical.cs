using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace Domain
{
    public class Chemical : Product
    {
      
        public string LabName { get; set; }
        public Adresse Adresse { get; set; }

        public override void GetMyType()
        {
            base.GetMyType();
            Console.WriteLine("CHEMICAL");
        }
    }
}
