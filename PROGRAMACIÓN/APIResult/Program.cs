using Microsoft.Owin.Hosting;
using System;

namespace NewAPIResult
{
    class Program
    {
        static void Main(string[] args)
        {
            string domainAddress = "http://localhost:59099";

            using (WebApp.Start(url: domainAddress))
            {
                Console.WriteLine("Service Hosted " + domainAddress);
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}


