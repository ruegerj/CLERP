using Microsoft.AspNetCore.Mvc.Filters;

namespace CLERP.API.Infrastructure.Attributes
{
    /// <summary>
    /// Custom attribute for erros in model validation
    /// Returns a custom formated error response if the validation of the model fails
    /// which lists all failed fields of the model
    /// </summary>   
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new ValidationFailedResult(context.ModelState);
            }
        }
    }
}
