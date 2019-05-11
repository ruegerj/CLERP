using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateDto : IRequest<Guid>
    {
        [Required]
        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [Required]
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("phone-number")]
        public string PhoneNumber { get; set; }

        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Plain password
        /// </summary>
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
    }
}
