using Confluent.Kafka;

namespace StudyKafka.Api.Kafka.Impl
{
    public class KafkaClient : IKafkaClient
    {
        private readonly IProducer<string, string> _producer;
        
        public KafkaClient(ProducerConfig config)
        {
            _producer = new ProducerBuilder<string, string>(config).Build();
        }

        public Handle Handle { get => _producer.Handle; }

        public void Dispose()
        {
            _producer?.Flush();
            _producer?.Dispose();
        }
    }
}