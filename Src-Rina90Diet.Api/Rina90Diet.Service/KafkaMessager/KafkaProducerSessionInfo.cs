using Confluent.Kafka;
using Rina90Diet.Service.KafkaMessager.KafkaReactive;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Blockchain.Service.KafkaMessager
{
    public class KafkaProducerSessionInfo
    {
        public Producer<string, string> Producer { get; set; }

        public BlockingCollection<Record<string, string>> ProducerBlockingQueue { get; set; }
    }
}
