using System;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.SayHelloService)))
            {
                host.Open();
                Console.WriteLine("Service started at @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
