using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.ServiceAccessLayer
{
    class CroweServices
    {
        HttpClient client = new HttpClient();
        public CroweServices()
        {
            client.BaseAddress = new Uri("http://localhost:54094/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> GetSecretMessage()
        {
          string message = await  GetProductAsync("api/CrowService/secretmessage");
          return message;
        }


        private async Task<string> GetProductAsync(string path)
        {
            String message="Sorry no Messages! Try again later";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }
    }
}
