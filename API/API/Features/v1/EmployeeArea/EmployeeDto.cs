using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea
{
    /// <summary>
    /// Default response dto for an employee
    /// </summary>
    public class EmployeeDto
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthday { get; set; }

        public string PhoneNumber { get; set; }

        public string Username { get; set; }
    }
}
