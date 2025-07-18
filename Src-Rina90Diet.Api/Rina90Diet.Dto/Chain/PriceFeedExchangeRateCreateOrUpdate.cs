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
    public partial class PriceFeedExchangeRateCreateOrUpdate
    {

        [JsonProperty("quote")]
        public AmountDescription Quote { get; set; }

        [JsonProperty("base")]
        public AmountDescription Base { get; set; }


    }
}
