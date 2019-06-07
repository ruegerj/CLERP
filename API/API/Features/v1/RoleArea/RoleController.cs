using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.RoleArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
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
        [Produces(typeof(GetAll.RoleGetAllResponse))]
        public async Task<ActionResult> GetAllRoles()
        {
            return Ok(await _mediator.Send(new GetAll.RoleGetAllRequest()));
        }

        /// <summary>
        /// Gets a role by id
        /// </summary>
        /// <param name="id">Id of the role</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Role found", typeof(RoleResponse))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(MessageResponse), Description = "Role couldn't be found")]
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
        /// Add's one ore more certain roles to an employee
        /// </summary>
        /// <param name="roleAddEmployeeData">Data for adding a role to an employee</param>
        /// <returns></returns>
        [HttpPost("add-to-employee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Role successfuly added to the employee")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Role or employee couln't be found")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Can't add role, the employee has this role already")]
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
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Role successfuly added to the department")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Role or department couln't be found")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Can't add role, the department has this role already")]
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
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Create.RoleCreateResponse), Description = "Role successfuly created")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        public async Task<ActionResult> CreateRole([FromBody] Create.RoleCreateRequest createData)
        {
            return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a role
        /// </summary>
        /// <param name="updateData">Updated role data</param>
        /// <param name="id">Id of the role</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(RoleResponse), Description = "Role successfuly updated")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(BadRequestResponse), Description = "Role couldn't be found")]
        public async Task<ActionResult> UpdateRole([FromBody] Update.RoleUpdateRequest updateData, Guid id)
        {
            updateData.RoleId = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Removes one or more certain roles from an employee
        /// </summary>
        /// <param name="removeRoleFromEmployeeData">Data for removing a role from an employee</param>
        /// <returns></returns>
        [HttpDelete("remove-from-employee")]
        [SwaggerResponse((int)HttpStatusCode.OK,
            Type = null,
            Description = "Role successfuly removed from the employee")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Role or employee couln't be found, or the employee doesn't have the role")]
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
        /// <returns></returns>
        [HttpDelete("remove-from-department")]
        [SwaggerResponse((int)HttpStatusCode.OK,
            Type = null,
            Description = "Role successfuly removed from the department")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Role or department couln't be found, or the department doesn't have the role")]
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
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Role deleted successfuly")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Role coulnd't be found")]
        public async Task<ActionResult> DeleteRole(Guid id)
        {
            await _mediator.Send(new Delete.RoleDeleteRequest() { RoleId = id });

            return Ok();
        }
    }
}