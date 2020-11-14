using System.Threading.Tasks;
using Confluent.Kafka;

namespace StudyKafka.Api.Kafka
{
    public interface IKafkaProducer
    {
         Task ProduceAsync(string topicName, Message<string, string> message);
    }
}