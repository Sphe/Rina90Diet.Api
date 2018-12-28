using Rina90Diet.Blockchain.Service.KafkaMessager.Contract;
using Rina90Diet.Blockchain.Service.LycServiceContract.Architecture;

namespace Rina90Diet.Blockchain.Service.KafkaMessager
{
    public class KafkaFacade : IKafkaFacade
    {
        private IKafkaProducerConsumerFactory _kafkaProducerConsumerFactory;

        public KafkaFacade(IKafkaProducerConsumerFactory kafkaProducerConsumerFactory)
        {
            _kafkaProducerConsumerFactory = kafkaProducerConsumerFactory;
        }

        public IKafkaProducerConsumerFactory ProducerConsumerStore
        {
            get { return _kafkaProducerConsumerFactory; }    
        }
    }
}
