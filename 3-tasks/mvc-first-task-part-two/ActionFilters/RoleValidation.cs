using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_first_task.ActionFilters
{
    public class RoleValidationAttribute : ActionFilterAttribute
    {
        private readonly string _requiredRole;

        public RoleValidationAttribute(string requiredRole)
        {
            _requiredRole = requiredRole;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var role = context.HttpContext.Request.Cookies["role"];

            if (role != _requiredRole)
            {
                context.Result = new RedirectToActionResult("NotAuth", "Login", null);
            }
            else if (string.IsNullOrEmpty(role)) context.Result = new RedirectToActionResult("Index", "Login", null);
        }
    }
}
