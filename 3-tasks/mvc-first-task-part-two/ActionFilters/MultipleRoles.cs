using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_first_task.ActionFilters
{
    public class MultipleRoles : ActionFilterAttribute
    {
        private readonly string[] _requiredRoles;

        public MultipleRoles(params string[] requiredRoles)
        {
            _requiredRoles = requiredRoles;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var role = context.HttpContext.Request.Cookies["role"];

            if (!_requiredRoles.Contains(role))
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }
            else if (string.IsNullOrEmpty(role))
            {
                context.Result = new RedirectToActionResult("Home", "Index", null);
            }
        }
    }
}
