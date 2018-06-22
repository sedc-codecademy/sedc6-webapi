using Newtonsoft.Json;
using ProductsManagement.Models.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsManagement.Repositories
{
    public class ProductsRepository
    {
        private string baseUrl = "http://10.10.86.140:8888";

        public async Task<List<GetPostResponse>> GetAllPostsAsync()
        {
var client = new HttpClient();
HttpResponseMessage response = await client.GetAsync($"{baseUrl}/posts");

if (!response.IsSuccessStatusCode)
    return null;

var content = await response.Content.ReadAsStringAsync();

var data = JsonConvert.DeserializeObject<List<GetPostResponse>>(content);

            return data;
        }
    }
}
