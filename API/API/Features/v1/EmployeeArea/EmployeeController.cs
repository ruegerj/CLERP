using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace CLERP.API.Features.v1.EmployeeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ValidateModel]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets an employee by his id
        /// </summary>
        /// <param name="id">id of the requested employee</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetEmployeeById(Guid id)
        {
            var employee = await _mediator.Send(new GetById.EmployeeGetByIdQuery() { EmployeeId = id });

            if (employee == null)
            {
                return NotFound(new { message = $"employee with id: {id} not found" });
            }

            return Ok(employee);
        }

        /// <summary>
        /// Creates an employee
        /// </summary>
        /// <param name="createData">Required data for creating an employee</param>
        /// <returns></returns>
        [HttpPost("create")]
        [AllowAnonymous]
        public async Task<ActionResult> CreateEmployee([FromBody] Create.EmployeeCreateDto createData)
        {
            await _mediator.Send(createData);

            return Ok(new ResponseContainer("Employee successfuly created."));
        }

        /// <summary>
        /// Logs a employee in and returns the created Jwt
        /// </summary>
        /// <param name="loginData">Username and password from the employee</param>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login([FromBody] Login.EmployeeLoginDto loginData)
        {
            var token = await _mediator.Send(loginData);

            if (token == null)
            {
                return UnprocessableEntity(new ResponseContainer("Invalid credentials", 
                    new { description = "The provided username or password is wrong"}));
            }

            return Ok(new ResponseContainer("Login successful",  new { token }));
        }
    }
}