namespace StudyKafka.Api.Configuration
{
    public class KafkaConfiguration
    {
        public string BootstrapServers { get; set; }
        public string Topic { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int MessageTimeoutMs { get; set; }
    }
}