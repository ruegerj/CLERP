using MediatR;
using System;

namespace CLERP.API.Features.v1.EmployeeArea.Delete
{
    public class EmployeeDeleteRequest : IRequest
    {
        /// <summary>
        /// Id of the employee which have to be deleted
        /// </summary>
        public Guid EmployeeId { get; set; }
    }
}
