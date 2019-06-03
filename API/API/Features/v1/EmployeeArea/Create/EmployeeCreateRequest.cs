using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.EmployeeArea.Create
{
    public class EmployeeCreateRequest : IRequest<EmployeeCreateResponse>
    {
        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Plain password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }
    }
}
