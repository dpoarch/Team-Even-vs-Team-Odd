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
        public int OddKey = 0;
        public int evenKey = 0;

        public List<TeamOdd> teamO;
        public List<TeamEven> teamE;
        

        public Team(dynamic obj)
        {
            teamE = new List<TeamEven>();
            teamO = new List<TeamOdd>();

            foreach (var myobj in obj)
            {
                int id = myobj.id;
                String name = myobj.name;
                String email = myobj.email;
                String address = myobj.address.city;
                String companyName = myobj.company.name;

                IdentifyTeam(
                 id,
                 name,
                 email,
                 address,
                 companyName);
            }

            Console.WriteLine("Assigning Team Members...");
        }


        public void IdentifyTeam(int Id, string Name, string Email, string City, string CompanyName)
        {
            
            
            if (Id % 2 == 0)
            {
                teamE.Add(new TeamEven());
                teamE[evenKey].Id = Id;
                teamE[evenKey].Name = Name;
                teamE[evenKey].Email = Email;
                teamE[evenKey].City = City;
                teamE[evenKey].CompanyName = CompanyName;
                evenKey++;
            }
            else
            {
                teamO.Add(new TeamOdd());
                teamO[OddKey].Id = Id;
                teamO[OddKey].Name = Name;
                teamO[OddKey].Email = Email;
                teamO[OddKey].City = City;
                teamO[OddKey].CompanyName = CompanyName;
                OddKey++;
            }
        }

        public void DisplayTeamEven()
        {
            Console.WriteLine("");
            Console.WriteLine("============================== Even Team List ==================================");

            for(int i = 0; i < teamE.Count(); i++)
            {
                int Id = teamE[i].Id;
                String Name = teamE[i].Name;
                String Email = teamE[i].Email;
                String City = teamE[i].City;
                String CompanyName = teamE[i].CompanyName;
                Console.WriteLine(String.Format("Id: {0} Name: {1} Emai: {2} City: {3} Company: {4}", Id, Name, Email, City, CompanyName));
            }
            Console.WriteLine("");
        }

        public void DisplayTeamOdd()
        {
            Console.WriteLine("");
            Console.WriteLine("============================== Odd Team List ==================================");

            for (int i = 0; i < teamO.Count(); i++)
            {
                int Id = teamO[i].Id;
                String Name = teamO[i].Name;
                String Email = teamO[i].Email;
                String City = teamO[i].City;
                String CompanyName = teamO[i].CompanyName;

                Console.WriteLine(String.Format("Id: {0} Name: {1} Emai: {2} City: {3} Company: {4}", Id, Name, Email, City, CompanyName));
            }
            Console.WriteLine("");
        }
    }
}
