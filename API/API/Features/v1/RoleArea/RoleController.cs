using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace CLERP.API.Features.v1.RoleArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ValidateModel]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets all roles
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(GetAll.RoleGetAllResponse))]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAll.RoleGetAllRequest()));
        }
    }
}