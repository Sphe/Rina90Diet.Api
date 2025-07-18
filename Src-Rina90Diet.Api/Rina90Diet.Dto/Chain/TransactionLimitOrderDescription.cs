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
    public partial class TransactionLimitOrderDescription
    {

        public TransactionLimitOrderDescription()
        {
            Operations = new List<Dictionary<string, LimitOrderBodyDescription>>();
            Signatures = new List<string>();
        }

        [JsonProperty("ref_block_num")]
        public ulong RefBlockNum { get; set; }

        [JsonProperty("ref_block_prefix")]
        public ulong RefBlockPrefix { get; set; }

        [JsonProperty("expiration")]
        public DateTime Expiration { get; set; }

        [JsonProperty("operations")]
        public List<Dictionary<string, LimitOrderBodyDescription>> Operations { get; set; }

        [JsonProperty("signatures")]
        public List<string> Signatures { get; set; }

        [JsonProperty("trx_in_block")]
        public int TrxInBlock { get; set; }

        [JsonProperty("block_num")]
        public ulong BlockNum { get; set; }

    }
}
