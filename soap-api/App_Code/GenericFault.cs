using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace soapapi
{
    [DataContract]
    [Serializable()]
    public class GenericFault
    {
        [DataMember]
        public int ResponseCode { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
