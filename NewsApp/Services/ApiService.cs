using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=6c762e15e041f6522f9add6d1f045707&topic=breaking-news&lang=en&topic=sports");

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
