using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClickUpAPIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Token YOUR_API_KEY");
                var response = await client.GetAsync("https://api.clickup.com/api/v2/task");

                if (response.IsSuccessStatusCode)
                {
                    var tasks = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(tasks);
                }
                else
                {
                    Console.WriteLine("Request failed with status code: " + response.StatusCode);
                }
            }
        }
    }
}
