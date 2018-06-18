using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace EmptyWebApi.Controllers
{
    [RoutePrefix("items")]
    public class ItemsController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetItems()
        {
            return Ok(new { id = 1, name = "asdasd" });
        }

        [HttpGet]
        [Route("{id:min(1)}")]
        public IHttpActionResult GetItemById(int id)
        {
            //unnecessary if specified as route parameter with constraint
            //if (!id.HasValue && id > 0)
            //    NotFound();

            return Ok(new { id = 1, name = "asdasd" });
        }

        [HttpDelete]
        [Route("{id:min(1)}")]
        public IHttpActionResult DeleteItemById(int id)
        {
            //unnecessary if specified as route parameter with constraint
            //if (!id.HasValue && id > 0)
            //    NotFound();

            return Ok(new { id = 1, name = "asdasd" });
        }
    }
}