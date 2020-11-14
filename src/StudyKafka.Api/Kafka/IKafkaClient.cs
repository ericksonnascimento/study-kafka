using System;
using Confluent.Kafka;

namespace StudyKafka.Api.Kafka
{
    public interface IKafkaClient : IDisposable
    {
        Handle Handle { get; }
    }
}