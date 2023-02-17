using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    internal class Program
    {
        public record class Todo(string? Title = null);

        private static HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://animejoy.ru/"),
        };

        static async Task GetAsync(HttpClient httpClient)
        {
            using HttpResponseMessage response = await httpClient.GetAsync("todos/3");


            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");

            // Expected output:
            //   GET https://jsonplaceholder.typicode.com/todos/3 HTTP/ 1.1
            //   {
            //     "userId": 1,
            //     "id": 3,
            //     "title": "fugiat veniam minus",
            //     "completed": false
            //   }
        }

        static async Task GetFromJsonAsync(HttpClient httpClient)
        {
            var todos = await httpClient.GetFromJsonAsync<List<Todo>>(
                "todos?Title=Шпионский класс [07 из 12]");

            Console.WriteLine("GET https://jsonplaceholder.typicode.com/todos?userId=1&completed=false HTTP/1.1");
            todos?.ForEach(Console.WriteLine);
            Console.WriteLine();
        }

        static async Task Main(string[] args)
        {
            await GetFromJsonAsync(httpClient);
            Console.ReadLine();
        }
    }
}
