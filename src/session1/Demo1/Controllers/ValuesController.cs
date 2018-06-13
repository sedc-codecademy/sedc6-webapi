using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Demo1.Controllers
{
    public class ValuesController : ApiController
    {
        /*
         * 
         * HTTPGET  /v1/products
         * HTTPPOST /v2/products
         * 
         * HTTPGET  /users/123/tweets/111/replies/23
         * HTTPPUT  /users/123/tweets/111/replies/23
         * HTTPPOST /users/123/tweets/111/replies
         * =>{
         * id=123123,
         * .....
         * }
         * HTTPDELETE /users/123/tweets/111/replies/23
         * 
         * 
         * HTTPGET  /replies/mk
         * HTTPGET  /tweets/
         * 404
         * {
         *   "id":100
         * },
         * 
         * {
         *   "status": "unauthorized",
         *   "response":{
         *      "id":100
         *   },
         *   "errors":[
         *      {},{},{}
         *   ],
         *   "next":"",
         *   "details":"/detailsFull/100"
         * }
         */

        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var message = new HttpRequestMessage(HttpMethod.Get,"twitter.com");
            message.Content = new StringContent("");
            
            var response =
                await new HttpClient().SendAsync(message);
            return new string[] { "value1", "value2" };
        }
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        public void Put(int id, [FromBody]string value)
        {
        }
        public void Delete(int id)
        {
        }
    }
}
