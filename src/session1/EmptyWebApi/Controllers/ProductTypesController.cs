
using EmptyWebApi.Models;
using System.Linq;
using System.Web.Http;

namespace EmptyWebApi.Controllers
{
    [RoutePrefix("product-types")]
    public class ProductTypesController: ApiController
    {
        /*
         * create ProductTypes controller
         * create model for ProductType(Id,Name)
         * install entity framework
         * implement entity framework DbContext
         * implement CRUD operation
         * CRUD => Create-Read-Update-Delete
         * Implement ValidateApiKeyAttribute(action filter)
         */
        private readonly DatabaseContext _context;

        public ProductTypesController()
        {
            _context = new DatabaseContext();
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAll()
        {
            var productTypes = _context.ProductTypes.ToList();
            return Ok(productTypes);
        }

        [HttpGet]
        [Route("{id:min(1)}")]
        public IHttpActionResult GetById(int id)
        {
            var productTypes = _context.ProductTypes.FirstOrDefault(x=>x.Id == id);
            if (productTypes == null)
                return NotFound();

            return Ok(productTypes);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Create(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            _context.SaveChanges();

            return Ok(productType);
        }

        [HttpPut]
        [Route("{id:min(1)}")]
        public IHttpActionResult Update(int id, ProductType productType)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var dbProductType = _context.ProductTypes.FirstOrDefault(x=>x.Id == id);
            if (dbProductType == null)
                return NotFound();

            dbProductType.Name = productType.Name;
            _context.SaveChanges();

            return Ok(productType);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var dbProductType = _context.ProductTypes.FirstOrDefault(x => x.Id == id);
            if (dbProductType == null)
                return NotFound();

            _context.ProductTypes.Remove(dbProductType);
            _context.SaveChanges();

            return Ok();
        }
    }
}