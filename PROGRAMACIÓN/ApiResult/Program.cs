using System;
using Microsoft.Owin.Hosting;

namespace ApiResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainAddress = "http://localhost:3333";

            using (WebApp.Start(url: domainAddress))
            {
                Console.WriteLine("Service Hosted " + domainAddress);
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}
