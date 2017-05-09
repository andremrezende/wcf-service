using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class OperationDAO
    {
        private static List<Data> operations = new List<Data>();

        public void Add(Data data)
        {
            OperationDAO.operations.Add(data);
        }

        public Data CurrentStatus(string operationName)
        {
            var result = OperationDAO.operations.Where(o => o.SoftwareVersion.Equals(operationName)).FirstOrDefault();
            return (Data) result;
        }
    }
}