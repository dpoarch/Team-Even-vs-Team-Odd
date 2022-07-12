using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _3_3Basketball_Gam
{
    public class Program
    {

        public const string URL = "https://jsonplaceholder.typicode.com/users";
        public const int Limiter = 6;
        static void Main(string[] args)
        {
            
            dynamic jsonObj = FetchAPI(); // returns Json Object from the API

            Team team = new Team(Limiter, jsonObj);

            team.DisplayTeamEven(); // displays list of even team
            team.DisplayTeamOdd(); // displays list of odd team

            Console.ReadLine();
        }

        static dynamic FetchAPI()
        {
           
            using (var client = new HttpClient()) // initialize HttpClient
            {
                var endpoint = new Uri(URL);

                
                var result = client.GetAsync(endpoint).Result; // result from the URL
                var json = result.Content.ReadAsStringAsync().Result;

                
                dynamic jsonObj = JsonConvert.DeserializeObject(json); // convert json to object


                return jsonObj;
            }
        }
    }
}
