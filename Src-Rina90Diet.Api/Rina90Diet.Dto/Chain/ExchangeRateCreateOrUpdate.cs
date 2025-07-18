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
    public partial class ExchangeRateCreateOrUpdate
    {

        public ExchangeRateCreateOrUpdate()
        {
            
        }

        [JsonProperty("base")]
        public AmountCreateOrUpdate Base { get; set; }

        [JsonProperty("quote")]
        public AmountCreateOrUpdate Quote { get; set; }
    }
}
