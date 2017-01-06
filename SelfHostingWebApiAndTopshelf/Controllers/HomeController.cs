using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using SelfHostingWebApiAndTopshelf.Interface;

namespace SelfHostingWebApiAndTopshelf.Controllers
{
    public class HomeController: ApiController
    {
        private readonly ITeste _teste;

        public HomeController(ITeste teste)
        {
            _teste = teste;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var cache = Request.GetOwinContext().Get<string>("teste");
            Request.GetOwinContext().Set("teste", "teste");
            var result = new {Result = _teste.GetString()};
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(JsonConvert.SerializeObject(result))
            };
        }
    }
}
