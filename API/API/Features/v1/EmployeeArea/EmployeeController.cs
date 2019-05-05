using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CLERP.API.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLERP.API.Features.v1.EmployeeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ValidateModel]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]       
        public async Task<ActionResult> CreateEmployee([FromBody] Create.EmployeeCreateDto createDto)
        {
            Create.Command createCommand = new Create.Command() { EmployeeData = createDto };

            await _mediator.Send(createCommand);

            return Ok(new { Message = "Employee successfuly created." });
        }
    }
}