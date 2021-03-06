﻿using CLERP.API.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CLERP.API.Infrastructure.Attributes
{
    /// <summary>
    /// Class to configure the default Http-Status code when the model validation fails
    /// Wraps arround the <see cref="ValidationFailedResponse"/>
    /// </summary>
    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(ModelStateDictionary modelState) : base(new ValidationFailedResponse(modelState))
        {
            StatusCode = StatusCodes.Status422UnprocessableEntity;
        }
    }
}
