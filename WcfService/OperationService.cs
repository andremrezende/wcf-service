using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class OperationService : IOperationService
    {
        public Data Search(string operationName)
        {
            OperationDAO dao = new OperationDAO();
            return dao.CurrentStatus(operationName);
        }

        public void Add(Data data)
        {
            OperationDAO dao = new OperationDAO();
            dao.Add(data);
        }
    }
}