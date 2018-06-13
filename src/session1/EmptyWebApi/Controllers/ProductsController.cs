using EmptyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmptyWebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly static List<Product> _products = new List<Product>();

        [HttpGet]
        [Route("products")]
        public IHttpActionResult GetAll()
        {
            return Ok(_products);
        }

        [HttpGet]
        [Route("products/{id:int}")]
        public IHttpActionResult Get(int id)
        {
            if (id == 0)
                return BadRequest();

            var product = _products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet]
        [Route("products/{id:alpha}")]
        public IHttpActionResult Get(string id)
        {
            return Ok("string ALPHA method called");
        }

        //[HttpGet]
        //[Route("products/{id:length(1,10)}")]
        //public IHttpActionResult GetAlpha(string id)
        //{
        //    return Ok("string method called");
        //}

        [HttpPost]
        [Route("products")]
        public IHttpActionResult Create(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
            return Ok(product);
        }

        //[HttpPost]
        //[Route("products")]
        //public IHttpActionResult Update(Product product)
        //{

        //}

        [HttpPut]
        [Route("products/{id:min(1)}")]
        public IHttpActionResult Update(int id, Product product, bool returnItBack = false)
        {
            if (product == null)
                return BadRequest();

            var dbProduct = _products.FirstOrDefault(x => x.Id == id);
            if (dbProduct == null)
                return NotFound();
            //dynamic human = null;
            //int zipcode = human?.country?.city?.zipcode ?? 0;

            //if(get1(true) && get2(true) && get3(false) && get4(true))

            //if (human != null && human.country != null && human.country.city != null && human.country.city != null)
            //    return Ok()


            //if (human != null)
            //    if (human.country != null)
            //        if (human.country.city != null)
            //            if (human.country.city != null)
            //                return Ok()

            dbProduct.Description = product.Description?.Trim(' ', '/', '\\') ?? "";
            dbProduct.Quantity = product.Quantity;


            if (returnItBack)
                return Ok(dbProduct);
            return Ok();
        }

    }
}
