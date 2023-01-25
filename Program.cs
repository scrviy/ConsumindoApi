using Newtonsoft.Json;
using Users;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumindoApi
{
    public class ConsumindoApi 
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient{ BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users")};
            var response = await client.GetAsync("users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach(var item in users)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
            }
        }
    }
}