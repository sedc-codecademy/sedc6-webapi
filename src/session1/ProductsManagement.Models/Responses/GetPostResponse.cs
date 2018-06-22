using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsManagement.Models.Responses
{
    public class GetPostResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
