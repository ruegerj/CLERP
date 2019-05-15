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

        /// <summary>
        /// Gets a role by id
        /// </summary>
        /// <param name="id">Id of the role</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(RoleResponse), Description = "Role found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.NotFound, responseType: typeof(MessageResponse), Description = "Role couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
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
        /// <returns></returns>
        [HttpPost("add-to-employee")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "Role successfuly added to the employee")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, 
            responseType: typeof(BadRequestResponse), 
            Description = "Role or employee couln't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict,
            responseType: typeof(ConflictResponse),
            Description = "Can't add role, the employee has this role already")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
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
        /// <returns></returns>
        [HttpPost("add-to-department")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null, Description = "Role successfuly added to the department")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Role or department couln't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict,
            responseType: typeof(ConflictResponse),
            Description = "Can't add role, the department has this role already")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> AddRoleToDepartment(
            [FromBody] AddToDepartment.RoleAddToDepartmentRequest roleAddDepartmentData)
        {
            await _mediator.Send(roleAddDepartmentData);

            return Ok();
        }

        /// <summary>
        /// Removes a certain role from an employee
        /// </summary>
        /// <param name="removeRoleFromEmployeeData">Data for removing a role from an employee</param>
        /// <returns></returns>
        [HttpPost("remove-from-employee")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK,
            responseType: null,
            Description = "Role successfuly removed from the employee")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Role or employee couln't be found, or the employee doesn't have the role")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> RemoveRoleFromEmployee(
            [FromBody] RemoveFromEmployee.RoleRemoveFromEmployeeRequest removeRoleFromEmployeeData)
        {
            await _mediator.Send(removeRoleFromEmployeeData);

            return Ok();
        }

        /// <summary>
        /// Removes a certain role from a department
        /// </summary>
        /// <param name="roleRemoveFromDepartmentData">Data for removing the role from the department</param>
        /// <returns></returns>
        [HttpPost("remove-from-department")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, 
            responseType: null, 
            Description = "Role successfuly removed from the department")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest,
            responseType: typeof(BadRequestResponse),
            Description = "Role or department couln't be found, or the department doesn't have the role")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> RemoveRoleFromDepartment(
            [FromBody] RemoveFromDepartment.RoleRemoveFromDepartmentRequest roleRemoveFromDepartmentData)
        {
            await _mediator.Send(roleRemoveFromDepartmentData);

            return Ok();
        }

        /// <summary>
        /// Creates a role
        /// </summary>
        /// <param name="createData">Data for creating a new role</param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(Create.RoleCreateResponse), Description = "Role successfuly created")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.Conflict,
            responseType: typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> CreateRole([FromBody] Create.RoleCreateRequest createData)
        {
            var roleIdDto = await _mediator.Send(createData);

            return Ok(roleIdDto);
        }

        /// <summary>
        /// Updates a role
        /// </summary>
        /// <param name="updateData">Updated role data</param>
        /// <param name="id">Id of the role</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: typeof(RoleResponse), Description = "Role successfuly updated")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, responseType: typeof(BadRequestResponse), Description = "Role couldn't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> UpdateRole([FromBody] Update.RoleUpdateRequest updateData, Guid id)
        {
            updateData.RoleId = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Deletes a role
        /// </summary>
        /// <param name="id">Id of the role</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.OK, responseType: null,  Description = "Role deleted successfuly")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.BadRequest, 
            responseType: typeof(BadRequestResponse), 
            Description = "Role coulnd't be found")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.UnprocessableEntity,
            responseType: typeof(ValidationFailedResponse),
            Description = "Validation failed")]
        [SwaggerResponse(httpStatusCode: HttpStatusCode.InternalServerError,
            responseType: typeof(MessageResponse),
            Description = "An unknown error occured")]
        public async Task<ActionResult> DeleteRole(Guid id)
        {
            await _mediator.Send(new Delete.RoleDeleteRequest() { RoleId = id });

            return Ok();
        }
    }
}