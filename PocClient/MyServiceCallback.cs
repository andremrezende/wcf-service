using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocClient.ServiceReference2;


namespace PocClient
{
    public class MyServiceCallback : IPocServerCallback
    {
        public void OnCallback(Data msg)
        {
            Console.WriteLine("> Received callback at {0}", DateTime.Now);
            Console.WriteLine("> Received callback message {0}", msg.TotalCount);
        }
    }
}
