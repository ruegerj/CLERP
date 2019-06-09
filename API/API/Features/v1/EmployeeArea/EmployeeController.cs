using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize(Roles = "SysAdmin, Management, HR")]
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
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.EmployeeGetAllResponse))]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAll.EmployeeGetAllRequest()));
        }

        /// <summary>
        /// Gets an employee by his id
        /// </summary>
        /// <param name="id">id of the requested employee</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(EmployeeResponse), Description = "Employee found")]
        [SwaggerResponse((int)HttpStatusCode.NotFound,
            Type = typeof(MessageResponse),
            Description = "Employee couldn't be found")]
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
        /// <returns></returns>
        [HttpPost("create")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create.EmployeeCreateResponse), Description = "Employee successfuly created")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        public async Task<ActionResult> CreateEmployee([FromBody] Create.EmployeeCreateRequest createData)
        {
            return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates the data from an employee
        /// </summary>
        /// <param name="updateData">Data to update</param>
        /// <param name="id">Id of the employee</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(EmployeeResponse), Description = "Employee successfuly updated")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(BadRequestResponse), Description = "Employee couldn't be found")]
        public async Task<ActionResult> UpdateEmployee([FromBody] Update.EmployeeUpdateRequest updateData, Guid id)
        {
            updateData.EmployeeId = id;

            return Ok(await _mediator.Send(updateData));
        }


        /// <summary>
        /// Deletes an employee
        /// </summary>
        /// <param name="id">Guid/Id from the employee</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Employee successfuly deleted")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Employee to delete couldn't be found")]
        public async Task<ActionResult> DeleteEmployee(Guid id)
        {
            await _mediator.Send(new Delete.EmployeeDeleteRequest() { EmployeeId = id });

            return Ok();
        }

        /// <summary>
        /// Logs a employee in and returns the created Jwt
        /// </summary>
        /// <param name="loginData">Username and password from the employee</param>
        /// <returns></returns>
        [HttpPost("login")]
        [AllowAnonymous]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Login.TokenResponse), Description = "Login successsful")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Invalid credentials")]
        public async Task<ActionResult> Login([FromBody] Login.EmployeeLoginRequest loginData)
        {
            return Ok(await _mediator.Send(loginData));
        }
    }
}