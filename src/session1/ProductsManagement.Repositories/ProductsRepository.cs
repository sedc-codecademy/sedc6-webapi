using ProductsManagement.Models.Responses;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ProductsManagement.Repositories
{
    public class ProductsRepository
    {
        private string baseUrl = "http://10.10.86.140:8888";

        public List<GetProductResponse> GetAllProducts()
        {
            var client = new HttpClient();



        }
    }
}
