using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    [ServiceContract]
    public interface IOperationService
    {
        [OperationContract]
        Data Search(string operationName);

        [OperationContract]
        void Add(Data operation);
    }
}
