using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace HttpExample
{
    public class EjemploHttpClientFactory
    {

        private readonly IHttpClientFactory  _httpClientFactory;

        public EjemploHttpClientFactory(EjemploHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = (IHttpClientFactory)httpClientFactory;
        }

        public async Task Test()
        {
            var client = _httpClientFactory.CreateClient();
            var result = await client.GetAsync("/apiperfilpersonal/ivanabad");
            Console.WriteLine(result.StatusCode);
        }
    }
}
