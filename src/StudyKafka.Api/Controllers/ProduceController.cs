using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudyKafka.Api.Kafka;
using StudyKafka.Api.Models;

namespace StudyKafka.Api.Controllers
{
    [ApiController]
    [Route("api/produce")]
    public class ProduceController : ControllerBase
    {
        private readonly IKafkaService _service;

        public ProduceController(IKafkaService service)
        {
            _service = service;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> ProduceMessage(CreateMessageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.ProduceAsync(request);

            return Ok();
        }
    }
}