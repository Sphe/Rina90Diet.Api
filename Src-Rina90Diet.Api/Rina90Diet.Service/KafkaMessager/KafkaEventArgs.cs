using Rina90Diet.Service.KafkaMessager.KafkaReactive;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Blockchain.Service.KafkaMessager
{
    public struct KafkaEventArgs
    {
        public Try<Record<string, string>> Record { get; set; }
    }
}
