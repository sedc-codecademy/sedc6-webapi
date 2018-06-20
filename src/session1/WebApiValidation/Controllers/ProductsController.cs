using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiValidation.Models;
using WebApiValidation.Models.Requests;

namespace WebApiValidation.Controllers
{
    [RoutePrefix("/products")]
    public class ProductsController: ApiController
    {
        private static List<Product> _products = new List<Product>();

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {

        }

        [HttpGet]
        [Route("{id:min(1)}")]
        public IHttpActionResult GetById(int id)
        {


        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(CreateProductRequest product)
        {

        }

        [HttpPut]
        [Route("{id:min(1)}")]
        public IHttpActionResult Update(int id, UpdateProductRequest product)
        {

        }

        [HttpDelete]
        [Route("{id:min(1)}")]
        public IHttpActionResult Delete(int id)
        {

        }
    }
}