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

namespace CLERP.API.Features.v1.DepartmentArea
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Consumes("application/json")]
    [Produces("application/json")]
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
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet]
        [Produces(typeof(GetAll.DepartmentGetAllResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> GetAllDepartments()
        {
            return Ok(await _mediator.Send(new GetAll.DepartmentGetAllRequest()));
        }

        /// <summary>
        /// Gets an department by the id
        /// </summary>
        /// <param name="id">Id of the department</param>
        /// <response code="404">Department couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces(typeof(DepartmentResponse))]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
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
        /// <response code="200">Employee successfuly added to the department</response>
        /// <response code="400">Department or employee couln't be found</response>
        /// <response code="409">Can't add employee, the department has this employee added already</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost("add-employee")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> AddEmployeeToDepartment([FromBody] AddEmployee.DepartmentAddEmployeeRequest departmentAddEmployeeData)
        {
            await _mediator.Send(departmentAddEmployeeData);

            return Ok();
        }

        /// <summary>
        /// Removes an employee from a department
        /// </summary>
        /// <param name="departmentRemoveEmployeeData">Data for removing an employee from a department</param>
        /// <response code="200">Employee successfuly removed from the department</response>
        /// <response code="400">Emplyoee or department couln't be found, or the department doesn't have this employee added</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("remove-employee")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
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
        /// <response code="200">Department successfuly created</response>
        /// <response code="409">Entered data conflicts with existing</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPost]
        [Produces(typeof(Create.DepartmentCreateResponse))]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> CreateDepartment([FromBody] Create.DepartmentCreateRequest createData)
        {
           return Ok(await _mediator.Send(createData));
        }

        /// <summary>
        /// Updates a department
        /// </summary>
        /// <param name="updateData">Updated department data</param>
        /// <param name="id">Id of the department to update</param>
        /// <response code="200">Department successfuly updated</response>
        /// <response code="400">Department couldn't be found</response>
        /// <response code="409">Entered data conflicts with existing</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces(typeof(DepartmentResponse))]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ConflictResponse), (int)HttpStatusCode.Conflict)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> UpdateDepartment([FromBody] Update.DepartmentUpdateRequest updateData, Guid id)
        {
            updateData.DepartmentId = id;

            return Ok(await _mediator.Send(updateData));
        }

        /// <summary>
        /// Deletes a department
        /// </summary>
        /// <param name="id">Id of the department</param>
        /// <response code="200">Department successfuly deleted</response>
        /// <response code="400">Department couldn't be found</response>
        /// <response code="422">Validation failed</response>
        /// <response code="500">An unknown error occured</response>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(BadRequestResponse), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ValidationFailedResponse), (int)HttpStatusCode.UnprocessableEntity)]
        [ProducesResponseType(typeof(MessageResponse), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult> DeleteDepartment(Guid id)
        {
            await _mediator.Send(new Delete.DepartmentDeleteRequest() { RoleId = id });

            return Ok();
        }
    }
}