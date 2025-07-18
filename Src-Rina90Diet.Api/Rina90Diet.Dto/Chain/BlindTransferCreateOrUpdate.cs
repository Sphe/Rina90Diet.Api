using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Rina90Diet.Dto.Chain
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BlindTransferCreateOrUpdate
    {

        public BlindTransferCreateOrUpdate()
        {
        }

        [DataMember(Name = "fromKeyOrLabel")]
        public string FromKeyOrLabel { get; set; }

        [DataMember(Name = "toKeyOrLabel")]
        public string ToKeyOrLabel { get; set; }

        [DataMember(Name = "amount")]
        public string Amount { get; set; }

        [DataMember(Name = "assetSymbol")]
        public string AssetSymbol { get; set; }

        [DataMember(Name = "broadcast")]
        public bool Broadcast { get; set; } = false;

    }
}
