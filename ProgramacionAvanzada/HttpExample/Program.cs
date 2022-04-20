using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpExample
{
    class Program
    {
        private static HttpClient Client = new HttpClient();
        static async Task Main(string[] args)
        {
            //No esta tan bien
            for(int i = 0; i <=10; i++)
            {
             
                    var result = await Client.GetAsync("https://www.netmentor.es");
             Console.WriteLine(result.StatusCode);
                
            }

            

        }
    }
}
