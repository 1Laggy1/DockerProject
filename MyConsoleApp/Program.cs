using System;
using Newtonsoft.Json;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "John", Age = 30 };

            string json = JsonConvert.SerializeObject(person);

            Console.WriteLine(json);
        }
    }
}
