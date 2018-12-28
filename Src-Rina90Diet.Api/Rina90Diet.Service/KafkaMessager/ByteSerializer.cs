using Confluent.Kafka.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rina90Diet.Service.KafkaMessager
{
    public class ByteSerializer : ISerializer<byte[]>
    {
        public IEnumerable<KeyValuePair<string, object>> Configure(IEnumerable<KeyValuePair<string, object>> config, bool isKey)
        {
            return config;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize(string topic, byte[] data)
        {
            return data;
        }
    }
}
