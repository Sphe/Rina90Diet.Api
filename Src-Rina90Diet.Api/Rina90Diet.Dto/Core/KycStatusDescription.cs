using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class KycStatusDescription
    {
        [DataMember(Name = "kycProcessId")]
        public string KycProcessId { get; set; }

        [DataMember(Name = "userVerificationStatusId")]
        public int UserVerificationStatusId { get; set; }

        [DataMember(Name = "userVerificationStatusName")]
        public string UserVerificationStatusName { get; set; }

        [DataMember(Name = "timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
