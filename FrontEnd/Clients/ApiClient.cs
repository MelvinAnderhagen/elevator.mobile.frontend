using FrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _client;
        public List<ErrorReport> Reports { get; private set; }

        public ApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task <List<ErrorReport>> GetAllErrorReports()
        {
            Reports = new List<ErrorReport>();

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "errorreport");
                var response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Reports = JsonConvert.DeserializeObject<List<ErrorReport>>(content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"\tERROR {0}", e.Message);
            }
            return Reports;
        }

        public async Task UpdateErrorReportStatus()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Put, "errorreport");
                var response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {

                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(@"\tERROR {0}", e.Message);
            }
        }
    }
}
