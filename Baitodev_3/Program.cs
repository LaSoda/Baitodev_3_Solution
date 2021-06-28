using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Baitodev_3
{
    class Program
    {   //finished out of time 

        static async Task Main(string[] args)
        {
            var url = "https://jsonplaceholder.typicode.com/users";
            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var Posts = JsonConvert.DeserializeObject<List<Post>>(response);

                foreach (var p in Posts)
                {
                    String FirstName = p.name.Split(' ')[0];
                    Console.WriteLine($"User FirstName:  {FirstName}");
                    Console.WriteLine($"User Mail:  {p.email}");
                    Console.WriteLine($"---------------------------");
                }
            }
        }
    }
}
