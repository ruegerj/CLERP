using MediatR;
using Newtonsoft.Json;
using System;

namespace CLERP.API.Features.v1.EmployeeArea.Update
{
    public class EmployeeUpdateRequest : IRequest<EmployeeResponse>
    {
        [JsonIgnore]
        public Guid EmployeeId { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// The current plain password of the employee, can be null  if a password change shouldn't be performed
        /// </summary>
        [JsonProperty("current-password")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// The new plain password from the employee, can be null if password change shouldn't be performed
        /// </summary>
        [JsonProperty("new-password")]
        public string NewPassword { get; set; }
    }
}
