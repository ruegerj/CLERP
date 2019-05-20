using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Features.v1;
using CLERP.API.Infrastructure.Attributes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace CLERP.API.Features.v1.ProductTypeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ValidateModel]
    public class ProductTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets all product types
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(GetAll.ProductTypeGetAllResponse))]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> GetAllProductTypes()
        {
            return Ok(await _mediator.Send(new GetAll.ProductTypeGetAllRequest()));
        }
    }
}