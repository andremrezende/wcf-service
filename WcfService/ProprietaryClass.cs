using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class ProprietaryClass
    {
        [DataMember]
        public string operation { get; set; }

        [DataMember]
        public string status { get; set; }
    }
}