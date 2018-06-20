using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiValidation.Models;
using WebApiValidation.Models.Requests;

namespace WebApiValidation.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        private static List<Product> _products = new List<Product>();

        public ProductsController()
        {
            //string name = "dzevo";
            //string fullname = name + " ibraimi";
            //fullname = fullname + " chetvrti";

            //var defaultValue = default(double);
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id:min(1)}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(CreateProductRequest product)
        {
            if (product == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }

        [HttpPut]
        [Route("{id:min(1)}")]
        public IHttpActionResult Update(int id, UpdateProductRequest product)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id:min(1)}")]
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}