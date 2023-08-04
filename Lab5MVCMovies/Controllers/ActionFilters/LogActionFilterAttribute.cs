using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Lab5MVCMovies.Controllers.ActionFilters
{
    public class LogActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            WriteLog("OnActionExecuted", context.RouteData);
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            WriteLog("OnActionExecuting", context.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            WriteLog("OnResultExecuted", context.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            WriteLog("OnResultExecuting", context.RouteData);
        }
        private void WriteLog(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["actions"];
            var message = String.Format("{0}- controller:{1} action:{2}", methodName, controllerName, actionName);
            Debug.WriteLine(message);
        }
    }
}
