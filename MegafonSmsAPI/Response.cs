using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MegafonSmsAPI
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "result")]
        public SendResult Result { get; set; }
    }
}
