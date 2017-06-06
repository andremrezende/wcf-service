using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Poc2.domain;

namespace Poc2
{
    [ServiceContract]
    interface IReceiver
    {
        [OperationContract]
        void send(Data data);
    }
}
