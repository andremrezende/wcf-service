using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Poc2.domain;

namespace Poc2
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]    
    public class PocServer : IPocServer, IReceiver
    {
        static Data returnMessage = null;
        public delegate void MessageReceivedType(Data data);
        public static event MessageReceivedType MessageReceived;
        public static IMyServiceCallback Callback;        

        public void TraceMessage(Data data)
        {
            //if we got a message, fire event
            if (MessageReceived != null)
                MessageReceived(data);
        }

        public void subscribe()
        {
            Callback = OperationContext.Current.GetCallbackChannel<IMyServiceCallback>();
            MessageReceived += new MessageReceivedType(delegate (Data data) {
                        returnMessage = data;

                       Callback.OnCallback(data);
            }); 
        }



        public Data getMsg()
        {
            return returnMessage;
            
        }

        public void receiveMsg(Data data)
        {            
            if (MessageReceived != null)
                MessageReceived(data);            
        }

        public void send(Data data)
        {
            if (MessageReceived != null)
                MessageReceived(data);
        }
    }
}
