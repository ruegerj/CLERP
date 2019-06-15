using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLERP.API.Features.v1.WarehouseArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize(Roles = "SysAdmin, Management, Production, Logistic, Sale")]
    [ValidateModel]
    public class WarehouseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WarehouseController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// Gets all warehouses including all shelves and compartments and the adress from the warehouses
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.WarehouseGetAllResponse))]
        public async Task<ActionResult> GetAllWarehouses()
        {
            return Ok(await _mediator.Send(new GetAll.WarehouseGetAllRequest()));
        }
    }
}