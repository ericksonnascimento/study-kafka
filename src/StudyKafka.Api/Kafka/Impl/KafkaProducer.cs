using System.Threading.Tasks;
using Confluent.Kafka;
using StudyKafka.Api.Configuration;

namespace StudyKafka.Api.Kafka.Impl
{
    public class KafkaProducer : IKafkaProducer
    {
        private readonly IProducer<string, string> _producer;
        public KafkaProducer(IKafkaClient client)
        {
            _producer = new DependentProducerBuilder<string, string>(client.Handle).Build();
        }

        public Task ProduceAsync(string topicName, Message<string, string> message) 
            => _producer.ProduceAsync(topicName, message);
    }
}