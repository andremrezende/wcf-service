using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class OperationDAO
    {
        private static List<ProprietaryClass> operations = new List<ProprietaryClass>();

        public void Add(ProprietaryClass proprietaryClass)
        {
            OperationDAO.operations.Add(proprietaryClass);
        }

        public ProprietaryClass CurrentStatus(string operationName)
        {
            var result = OperationDAO.operations.Where(o => o.operation.Equals(operationName)).FirstOrDefault();
            return (ProprietaryClass) result;
        }
    }
}