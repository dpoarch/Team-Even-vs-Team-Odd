using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_3Basketball_Gam.Model;

namespace _3_3Basketball_Gam
{
    class Team
    {
        public int Id;
        public string Name;
        public string Email;
        public string City;
        public string CompanyName;
        
        public Team(dynamic obj)
        {
            foreach (var myobj in obj)
            {
                Id = myobj.id;
                Name = myobj.name;
                Email = myobj.email;
                City = myobj.address.city;
                CompanyName = myobj.company.name;
            }
            Console.WriteLine("Assigning team...");
        }
    }
}
