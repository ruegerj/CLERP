using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginDto : IRequest<string>
    {
        public string Username { get; set; }

        /// <summary>
        /// Plain password
        /// </summary>
        public string Password { get; set; }
    }
}
