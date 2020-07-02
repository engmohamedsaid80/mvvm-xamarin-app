using Newtonsoft.Json;
using QuotesApp.Interfaces;
using QuotesApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp.Services
{
    public class QuotesApiService : IQuotesService
    {
        public async Task<List<QuotesRestModel>> GetQuotesAsync()
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync("https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes");

            return JsonConvert.DeserializeObject<List<QuotesRestModel>>(response);
        }
    }
}
