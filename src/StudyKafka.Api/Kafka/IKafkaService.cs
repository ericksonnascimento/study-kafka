using System.Threading.Tasks;
using StudyKafka.Api.Models;

namespace StudyKafka.Api.Kafka
{
    public interface IKafkaService
    {
         Task ProduceAsync(CreateMessageRequest request);
    }
}