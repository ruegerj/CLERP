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

namespace CLERP.API.Features.v1.EmployeeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
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
        /// Gets all employees
        /// </summary>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.EmployeeGetAllResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAll.EmployeeGetAllRequest()));
        }

        /// <summary>
        /// Gets an employee by his id
        /// </summary>
        /// <param name="id">id of the requested employee</param>
        /// <response code="404">Employee couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces(typeof(EmployeeResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<EmployeeResponse>> GetEmployeeById(Guid id)
        {
            var employee = await _mediator.Send(new GetById.EmployeeGetByIdRequest() { EmployeeId = id });

            if (employee == null)
            {
                return NotFound(new MessageResponse($"employee with the id: {id} couldn't be found"));
            }

            return Ok(employee);
        }

        /// <summary>
        /// Creates an employee
        /// </summary>
        /// <param name="createData">Required data for creating an employee</param>
        /// <response code="200">Employee successfuly created</response>
        /// <response code="409">Entered data conflicts with existing</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost("create")]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> CreateEmployee([FromBody] Create.EmployeeCreateRequest createData)
        {
            await _mediator.Send(createData);

            return Ok();
        }

        /// <summary>
        /// Updates the data from an employee
        /// </summary>
        /// <param name="updateData">Data to update</param>
        /// <param name="id">Id of the employee</param>
        /// <response code="200">Employee successfuly updated</response>
        /// <response code="400">Employee couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces(typeof(EmployeeResponse))]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> UpdateEmployee([FromBody] Update.EmployeeUpdateRequest updateData, Guid id)
        {
            updateData.EmployeeId = id;

            return Ok(await _mediator.Send(updateData));
        }


        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">Guid/Id from the employee</param>
        /// <response code="200">Employee successfuly deleted</response>
        /// <response code="400">Employee couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> DeleteEmployee(Guid id)
        {
            await _mediator.Send(new Delete.EmployeeDeleteRequest() { EmployeeId = id });

            return Ok();
        }

        /// <summary>
        /// Logs a employee in and returns the created Jwt
        /// </summary>
        /// <param name="loginData">Username and password from the employee</param>
        /// <response code="200">Login successful</response>
        /// <response code="400">Invalid credentials</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        [Produces(typeof(Login.TokenResponse))]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> Login([FromBody] Login.EmployeeLoginRequest loginData)
        {                    
            return Ok(await _mediator.Send(loginData));
        }
    }
}