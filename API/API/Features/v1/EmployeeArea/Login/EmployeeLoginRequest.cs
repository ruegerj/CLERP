using MediatR;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CLERP.API.Features.v1.EmployeeArea.Login
{
    public class EmployeeLoginRequest : IRequest<TokenResponse>
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
