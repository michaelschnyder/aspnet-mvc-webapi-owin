using System;
using System.Net.Http;

using AspNet.Web.Api;

using Microsoft.Owin.Hosting;

using MyProject.Web.SelfHost.OwinSelfhostSample;

namespace MyProject.Web.SelfHost
{
    /// <summary>
    /// See: http://www.asp.net/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Make sure the other assembly is loaded
            var typeLoaded = typeof(DefaultController);

            string baseAddress = "http://localhost:9001/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/status").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Console.ReadLine(); 
        }
    }
}
