using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateDto
    {
        public string Lastname { get; set; }

        public string Firstname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Username { get; set; }

        /// <summary>
        /// Plain password
        /// </summary>
        public string Password { get; set; }

        public DateTime Birthday { get; set; }
    }
}
