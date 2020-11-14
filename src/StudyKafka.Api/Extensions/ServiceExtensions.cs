using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudyKafka.Api.Configuration;
using StudyKafka.Api.Kafka;
using StudyKafka.Api.Kafka.Impl;

namespace StudyKafka.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddKafka(this IServiceCollection services, IConfiguration configuration)
        {

            var kafkaConfiguration = configuration.GetSection("KafkaConfiguration").Get<KafkaConfiguration>();
            var producerConfig = GetProducerConfig(kafkaConfiguration);

            services.AddSingleton(kafkaConfiguration);
            services.AddSingleton(producerConfig);
            services.AddSingleton<IKafkaClient, KafkaClient>();
            services.AddSingleton<IKafkaProducer, KafkaProducer>();
            services.AddSingleton<IKafkaService, KafkaService>();

            return services;
        }

        private static ProducerConfig GetProducerConfig(KafkaConfiguration kafkaConfiguration)
        {
            return new ProducerConfig
            {
                BootstrapServers = kafkaConfiguration.BootstrapServers,
                SaslUsername = kafkaConfiguration.Username,
                SaslPassword = kafkaConfiguration.Password,
                SaslMechanism = SaslMechanism.Plain,
                SslEndpointIdentificationAlgorithm = SslEndpointIdentificationAlgorithm.Https,
                Acks = Acks.All,
                SecurityProtocol = SecurityProtocol.SaslSsl,
                MessageTimeoutMs = kafkaConfiguration.MessageTimeoutMs
            };
        }
    }
}