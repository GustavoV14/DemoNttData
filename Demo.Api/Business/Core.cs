using NTTData.Dto;
using static NTTData.Dto.Response;

namespace NTTData.Business
{
    public class Core
    {
        public Core() { }
        public Response GetWelcome (Request rq)
        {
            Response.Const data = new Response.Const();
            return new Response { message = data.hello+rq.to+ data.wellcome }; 
        }
    }
}
