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
    public partial class AddOperationTransactionCreateOrUpdate
    {

        public AddOperationTransactionCreateOrUpdate()
        {
            
        }
        
        [DataMember(Name="transactionHandle")]
        public TransactionHandleDescription TransactionHandle { get; set; }

        [DataMember(Name = "operation")]
        public OperationDescription Operation { get; set; }

    }
}
