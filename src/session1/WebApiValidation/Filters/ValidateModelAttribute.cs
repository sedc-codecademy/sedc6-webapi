using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiValidation.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public string ErrorLogDestination { get; set; }

        public ValidateModelAttribute(bool shouldLogError)
        {

        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            
            //if (actionContext.Request.Content == null)
            //{
            //    actionContext.ModelState
            //        .AddModelError("request.body", "request is empty");
            //    actionContext.Response = actionContext.Request
            //        .CreateErrorResponse
            //        (HttpStatusCode.BadRequest, actionContext.ModelState);
            //    return;
            //}
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest,
                    actionContext.ModelState);
            }
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
        }
    }
}