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
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(EmployeeResponse), Description = "Employee found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.NotFound, 
            responseType: typeof(MessageResponse), 
            Description = "Employee couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult<EmployeeResponse>> GetEmployeeById(Guid id)
        {
            var employee = await _mediator.Send(new GetById.EmployeeGetByIdQuery() { EmployeeId = id });

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
        /// <returns></returns>
        [HttpPost("create")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, null, Description = "Employee successfuly created")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity, 
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError, 
            responseType: typeof(MessageResponse), 
            Description = "An unknown error occured")]
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
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(EmployeeResponse), Description = "Employee successfuly updated")]        
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, responseType: typeof(MessageResponse), Description = "Employee couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> UpdateEmployee([FromBody] Update.EmployeeUpdateRequest updateData, Guid id)
        {
            updateData.EmployeeId = id;

            var updatedEmployee = await _mediator.Send(updateData);

            if (updatedEmployee == null) // Employee not found
            {
                return BadRequest(new MessageResponse($"The employee with the id: {id} couldn't be updated, because it couldn't be found"));
            }

            return Ok(updatedEmployee);
        }


        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">Guid/Id from the employee</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "Employee successfuly deleted")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(MessageResponse), 
            Description = "Employee to delete couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> DeleteEmployee(Guid id)
        {
            var successfulyDeleted = await _mediator.Send(new Delete.EmployeeDeleteRequest() { EmployeeId = id });

            if (!successfulyDeleted) // Employee not found
            {
                return BadRequest(new MessageResponse($"Employee with the id: {id} doesn't exists or has already been deleted"));
            }

            return Ok();
        }

        /// <summary>
        /// Logs a employee in and returns the created Jwt
        /// </summary>
        /// <param name="loginData">Username and password from the employee</param>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(Login.TokenResponse), Description = "Login successsful")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, 
            responseType: typeof(MessageResponse), 
            Description = "Invalid credentials")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> Login([FromBody] Login.EmployeeLoginRequest loginData)
        {
            var tokenResponse = await _mediator.Send(loginData);

            if (tokenResponse == null)
            {
                return BadRequest(new MessageResponse("The provided username or password is invalid"));
            }

            return Ok(tokenResponse);
        }
    }
}