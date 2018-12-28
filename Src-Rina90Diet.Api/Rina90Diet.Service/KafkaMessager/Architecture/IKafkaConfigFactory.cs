using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Blockchain.Service.LycServiceContract
{
    public interface IKafkaConfigFactory
    {
        bool EnableAutoCommit { get; }
        string BrokerList { get; }
    }
}
