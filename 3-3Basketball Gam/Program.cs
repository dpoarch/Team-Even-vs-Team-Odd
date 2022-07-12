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
            dynamic jsonObj = FetchAPI();
            
            Team team = new Team(Limiter, jsonObj);

            team.DisplayTeamEven();
            team.DisplayTeamOdd();

            Console.ReadLine();
        }

        static dynamic FetchAPI()
        {
            using (var client = new HttpClient())
            {
                var endpoint = new Uri(URL);
                var result = client.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                return jsonObj;
            }
        }
    }
}
