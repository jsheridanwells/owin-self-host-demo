using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace OwinSelfHostDemo
{
    class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/Values").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}
