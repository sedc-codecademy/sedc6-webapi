using Newtonsoft.Json;
using ProductsManagement.Models;
using ProductsManagement.Models.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProductsManagement.Repositories
{
    public class PostsRepository
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

        public async Task <Post> CreatePostAsync(Post p)
        {
            HttpClient client = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(p));
            var response =  await client.PostAsync($"{baseUrl}/posts", content);

            if (!response.IsSuccessStatusCode)
                return null;

            var resultContent = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<Post>(resultContent);
            return data;
        }
    }
}
