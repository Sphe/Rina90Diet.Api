using Rina90Diet.Blockchain.Service.LycServiceContract.Architecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Blockchain.Service.KafkaMessager.Contract
{
    public interface IKafkaFacade
    {
        IKafkaProducerConsumerFactory ProducerConsumerStore { get; }
    }
}
