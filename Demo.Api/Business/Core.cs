using Demo.Api.Dto;
using static Demo.Api.Dto.Response;

namespace Demo.Api.Business
{
    public class Core
    {
        public Core() { }
        public Response GetWelcome(Request rq)
        {
            Const data = new Const();
            return new Response { message = data.hello + rq.to + data.wellcome };
        }
    }
}
