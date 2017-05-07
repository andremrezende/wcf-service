using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class OperationService : IOperationService
    {
        public ProprietaryClass Search(string operationName)
        {
            OperationDAO dao = new OperationDAO();
            return dao.CurrentStatus(operationName);
        }

        public void Add(ProprietaryClass operation)
        {
            OperationDAO dao = new OperationDAO();
            dao.Add(operation);
        }
    }
}