using Swashbuckle.AspNetCore.Annotations;

namespace Demo.Api.Dto
{
    public class Request
    {
        [SwaggerParameter(Description = "Mensaje")]
        public string? message { get; set; }
        [SwaggerParameter(Description = "a")]
        public string? to { get; set; }
        [SwaggerParameter(Description = "de")]
        public string? from { get; set; }
        [SwaggerParameter(Description = "Tiempo de Vida")]
        public int? timeToLifeSec { get; set; }

    }
}
