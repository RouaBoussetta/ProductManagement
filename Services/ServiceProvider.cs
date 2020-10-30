using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceProvider
    {
        public List<Provider> Providers;
        
        public List<DateTime> GetProviderByName(string name)
        {
            var req = from p in Providers
                      where p.UserName == name
                      select p.DateCreated;
            return req.ToList();
        }
        public Provider GetFirstProviderByName(string name)
        {
            var req = from p in Providers
                      where p.UserName == name
                      select p;
            return req.First();
        }

        public Provider GetProviderById(int id)
        {
            var req = from p in Providers
                      where p.Id == id
                      select p;
            return req.First();
        }


    }
}
