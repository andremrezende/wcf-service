using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Poc2.domain;

namespace Poc2
{
    public interface IMyServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnCallback(Data data);
    }
}
