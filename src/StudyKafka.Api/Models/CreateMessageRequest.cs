using System.ComponentModel.DataAnnotations;

namespace StudyKafka.Api.Models
{
    public class CreateMessageRequest
    {
        [Required]
        public string Message { get; set; }
    }
}