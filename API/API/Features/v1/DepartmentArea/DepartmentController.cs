using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CLERP.API.Infrastructure.Attributes;
using CLERP.API.Infrastructure.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CLERP.API.Features.v1.DepartmentArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ValidateModel]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets all roles
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.DepartmentGetAllResponse))]
        public async Task<ActionResult> GetAllDepartments()
        {
            return Ok(await _mediator.Send(new GetAll.DepartmentGetAllRequest()));
        }

        /// <summary>
        /// Gets an department by the id
        /// </summary>
        /// <param name="id">Id of the department</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DepartmentResponse), Description = "Department found")]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Type = typeof(MessageResponse), Description = "Department couldn't be found")]
        public async Task<ActionResult> GetDepartmentById(Guid id)
        {
            var department = await _mediator.Send(new GetById.DepartmentGetByIdRequest() { DepartmentId = id });

            if (department == null)
            {
                return NotFound(new MessageResponse($"Department with the id: {id} couldn't be found"));
            }

            return Ok(department);
        }

        /// <summary>
        /// Adds an employee to a department
        /// </summary>
        /// <param name="departmentAddEmployeeData">Data for adding an employee to a department</param>
        /// <returns></returns>
        [HttpPost("add-employee")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Employee successfuly added to the department")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Department or employee couln't be found")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Can't add employee, the department has this employee added already")]
        public async Task<ActionResult> AddEmployeeToDepartment([FromBody] AddEmployee.DepartmentAddEmployeeRequest departmentAddEmployeeData)
        {
            await _mediator.Send(departmentAddEmployeeData);

            return Ok();
        }

        /// <summary>
        /// Removes an employee from a department
        /// </summary>
        /// <param name="departmentRemoveEmployeeData">Data for removing an employee from a department</param>
        /// <returns></returns>
        [HttpPost("remove-employee")]
        [SwaggerResponse((int)HttpStatusCode.OK,
            Type = null,
            Description = "Employee successfuly removed from the department")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Emplyoee or department couln't be found, or the department doesn't have this employee added")]
        public async Task<ActionResult> RemoveEmployeeFromDepartment(
            [FromBody] RemoveEmployee.DepartmentRemoveEmployeeRequest departmentRemoveEmployeeData)
        {
            await _mediator.Send(departmentRemoveEmployeeData);

            return Ok();
        }

        /// <summary>
        /// Creates a department
        /// </summary>
        /// <param name="createData">Data for creating a new departmen</param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.OK, 
            Type = typeof(Create.DepartmentCreateResponse), 
            Description = "Department successfuly created")]
        [SwaggerResponse((int)HttpStatusCode.Conflict,
            Type = typeof(ConflictResponse),
            Description = "Entered data conflicts with existing")]
        public async Task<ActionResult> CreateDepartment([FromBody] Create.DepartmentCreateRequest createData)
        {
           return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a department
        /// </summary>
        /// <param name="updateData">Updated department data</param>
        /// <param name="id">Id of the department to update</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DepartmentResponse), Description = "Department successfuly updated")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, 
            Type = typeof(BadRequestResponse), 
            Description = "Department couldn't be found")]
        public async Task<ActionResult> UpdateDepartment([FromBody] Update.DepartmentUpdateRequest updateData, Guid id)
        {
            updateData.DepartmentId = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Deletes a department
        /// </summary>
        /// <param name="id">Id of the department</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = null, Description = "Department deleted successfuly")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest,
            Type = typeof(BadRequestResponse),
            Description = "Department coulnd't be found")]
        public async Task<ActionResult> DeleteDepartment(Guid id)
        {
            await _mediator.Send(new Delete.DepartmentDeleteRequest() { RoleId = id });

            return Ok();
        }
    }
}