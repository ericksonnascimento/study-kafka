using System;
using System.Text.Json;
using System.Threading.Tasks;
using Confluent.Kafka;
using StudyKafka.Api.Configuration;
using StudyKafka.Api.Models;

namespace StudyKafka.Api.Kafka.Impl
{
    public class KafkaService : IKafkaService
    {
        private readonly IKafkaProducer _producer;
        private readonly string _topicName;

        public KafkaService(IKafkaProducer producer, KafkaConfiguration kafkaConfiguration)
        {
            _producer = producer;
            _topicName = kafkaConfiguration.Topic;
        }

        public async Task ProduceAsync(CreateMessageRequest request)
        {
            var message = BuildMessage(request);

            await _producer.ProduceAsync(_topicName, message);
        }

        private Message<string, string> BuildMessage(CreateMessageRequest request)
        {
            return new Message<string, string>
            {
                Key = Guid.NewGuid().ToString(),
                Value = JsonSerializer.Serialize(request)
            };
        }
    }
}