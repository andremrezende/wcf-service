using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Poc2.domain;

namespace Poc2
{    
    [ServiceContract(CallbackContract = typeof(IMyServiceCallback))]
    public interface IPocServer
    {
        [OperationContract]        
        void subscribe();

        [OperationContract]
        void receiveMsg(Data data);

        [OperationContract]
        Data getMsg();
    }
}
