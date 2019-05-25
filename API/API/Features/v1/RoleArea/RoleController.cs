using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CLERP.API.Features.v1.RoleArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
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
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.RoleGetAllResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> GetAllDRoles()
        {
            return Ok(await _mediator.Send(new GetAll.RoleGetAllRequest()));
        }

        /// <summary>
        /// Gets a role by id
        /// </summary>
        /// <param name="id">Id of the role</param>
        /// <response code="404">Role couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces(typeof(RoleResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> GetRoleById(Guid id)
        {
            var role = await _mediator.Send(new GetById.RoleGetByIdRequest() { RoleId = id });

            if (role == null)
            {
                return NotFound(new MessageResponse($"Role with the id: {id} couldn't be found"));
            }

            return Ok(role);
        }

        /// <summary>
        /// Add's a certain role to an employee
        /// </summary>
        /// <param name="roleAddEmployeeData">Data for adding a role to an employee</param>
        /// <response code="200">Role successfuly added to the employeed</response>
        /// <response code="400">Role or employee couln't be found</response>
        /// <response code="409">Can't add role, the employee has this role already</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost("add-to-employee")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> AddRoleToEmployee(
            [FromBody] AddToEmployee.RoleAddToEmployeeRequest roleAddEmployeeData)
        {
            await _mediator.Send(roleAddEmployeeData);

            return Ok();
        }


        /// <summary>
        /// Adds a certain role to a department
        /// </summary>
        /// <param name="roleAddDepartmentData">Data for adding a role to a department</param>
        /// <response code="200">Role successfuly added to the department</response>
        /// <response code="400">Role or department couln't be found</response>
        /// <response code="409">Can't add role, the department has this role already</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost("add-to-department")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> AddRoleToDepartment(
            [FromBody] AddToDepartment.RoleAddToDepartmentRequest roleAddDepartmentData)
        {
            await _mediator.Send(roleAddDepartmentData);

            return Ok();
        }

        /// <summary>
        /// Creates a role
        /// </summary>
        /// <param name="createData">Data for creating a new role</param>
        /// <response code="200">Role successfuly created</response>
        /// <response code="409">Entered data conflicts with existing</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(Create.RoleCreateResponse))]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> CreateRole([FromBody] Create.RoleCreateRequest createData)
        {
            return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a role
        /// </summary>
        /// <param name="updateData">Updated role data</param>
        /// <param name="id">Id of the role</param>
        /// <response code="200">Role successfuly updated</response>
        /// <response code="400">Role couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces(typeof(RoleResponse))]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> UpdateRole([FromBody] Update.RoleUpdateRequest updateData, Guid id)
        {
            updateData.RoleId = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Removes a certain role from an employee
        /// </summary>
        /// <param name="removeRoleFromEmployeeData">Data for removing a role from an employee</param>
        /// <response code="200">Role successfuly removed from the employee</response>
        /// <response code="400">Role or employee couln't be found, or the employee doesn't have the role</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("remove-from-employee")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> RemoveRoleFromEmployee(
            [FromBody] RemoveFromEmployee.RoleRemoveFromEmployeeRequest removeRoleFromEmployeeData)
        {
            await _mediator.Send(removeRoleFromEmployeeData);

            return Ok();
        }

        /// <summary>
        /// Removes a certain role from a department
        /// </summary>
        /// <param name="removeRoleFromDepartmentData">Data for removing the role from the department</param>
        /// <response code="200">Role successfuly removed from the department</response>
        /// <response code="400">Role or department couln't be found, or the department doesn't have the role</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("remove-from-department")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> RemoveRoleFromDepartment(
            [FromBody] RemoveFromDepartment.RoleRemoveFromDepartmentRequest removeRoleFromDepartmentData)
        {
            await _mediator.Send(removeRoleFromDepartmentData);

            return Ok();
        }

        /// <summary>
        /// Deletes a role
        /// </summary>
        /// <param name="id">Id of the role</param>
        /// <response code="200">Role successfuly deleted</response>
        /// <response code="400">Role couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> DeleteRole(Guid id)
        {
            await _mediator.Send(new Delete.RoleDeleteRequest() { RoleId = id });

            return Ok();
        }
    }
}