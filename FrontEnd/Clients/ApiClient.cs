using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _client;

        public ApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task GetAllErrorReports()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "errorreport");
                var response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    
                }
                
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
