using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsManagement.Models.Responses
{
    public class GetProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ProductTypeId { get; set; }
        public Producttype ProductType { get; set; }
    }

    public class Producttype
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
