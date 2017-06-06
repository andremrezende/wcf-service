using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PocClient.ServiceReference1;
using System.ServiceModel;
using PocClient.ServiceReference2;

namespace PocClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var callback = new MyServiceCallback();
            var instanceContext = new InstanceContext(callback);
            PocServerClient service = new PocServerClient(instanceContext);

            var callback2 = new MyServiceCallback();
            var instanceContext2 = new InstanceContext(callback2);
            PocServerClient service2 = new PocServerClient(instanceContext2);

            ReceiverClient receiverService = new ReceiverClient();
            Data data = new Data();
            data.TotalCount = 10;

            service.subscribe();
            service2.subscribe();

            receiverService.send(data);

            //service.receiveMsg("Teste");
            Data msg = service.getMsg();

            Console.WriteLine("Msg : " + msg);
            Console.ReadLine();
        }
    }
}
