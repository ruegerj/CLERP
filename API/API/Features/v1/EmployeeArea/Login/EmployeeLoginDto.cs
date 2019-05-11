using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginDto : IRequest<string>
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Plain password
        /// </summary>
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
