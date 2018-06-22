using EmptyWebApi.Models;
using EmptyWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmptyWebApi.Controllers
{
    [RoutePrefix("products")]
    public class ProductsController : ApiController
    {
        private readonly DatabaseContext _context;

        public ProductsController()
        {
            _context = new DatabaseContext();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var data = _context.Products
                .Select(p=>new GetProductsVM
                {
                    Id = p.Id,
                    Description = p.Description,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    ProductTypeId = p.ProductTypeId,
                    ProductType = new GetProductsProductTypeVM
                    {
                        Id = p.ProductType.Id,
                        Name = p.ProductType.Name
                    }
                })
                .ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("{id:min(1)}")]
        public IHttpActionResult Get(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        
        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpPut]
        [Route("{id:min(1)}")]
        public IHttpActionResult Update(int id, Product product, bool returnItBack = false)
        {
            if (product == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dbProduct = _context.Products.FirstOrDefault(x => x.Id == id);
            if (dbProduct == null)
                return NotFound();

            dbProduct.Name = product.Name;
            dbProduct.ProductTypeId = product.ProductTypeId;
            dbProduct.Description = product.Description?.Trim(' ', '/', '\\') ?? "";
            dbProduct.Quantity = product.Quantity;
            _context.SaveChanges();

            if (returnItBack)
                return Ok(dbProduct);
            return Ok();

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
        }


        [HttpDelete]
        [Route("{id:min(1)}")]
        public IHttpActionResult Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }

        //[HttpGet]
        //[Route("products/{id:alpha}")]
        //public IHttpActionResult Get(string id)
        //{
        //    return Ok("string ALPHA method called");
        //}

        //[HttpGet]
        //[Route("products/{id:length(1,10)}")]
        //public IHttpActionResult GetAlpha(string id)
        //{
        //    return Ok("string method called");
        //}
    }
}
