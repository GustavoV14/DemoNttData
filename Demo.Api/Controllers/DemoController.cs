using Demo.Api.Business;
using Demo.Api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("DevOps")]
    public class DemoController : ControllerBase
    {
        private const string API_KEY = "2f5ae96c-b558-4c7b-a590-a501ae1c3f6c";
        public DemoController()
        {
        }

        [HttpPost]
        public IActionResult GetWelcome(Request request)
        {
            Core service = new Core();
            if (!IsValidApiKey())
            {
                return Unauthorized();
            }
            if (request == null || string.IsNullOrWhiteSpace(request.message) ||
            string.IsNullOrWhiteSpace(request.to) || string.IsNullOrWhiteSpace(request.from) ||
            request.timeToLifeSec <= 0)
            {
                return BadRequest("Payload inválido");
            }
            return Ok(service.GetWelcome(request));
        }

        private bool IsValidApiKey()
        {
            if (Request.Headers.TryGetValue("APIKey", out var apiKeyValue))
            {
                return apiKeyValue.Equals(API_KEY);
            }

            return false;
        }
    }
}
