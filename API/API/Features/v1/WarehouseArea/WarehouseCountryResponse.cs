using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Response dto for country data inside a request targeting the warehouse controller
    /// </summary>
    public class WarehouseCountryResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The abbrevation of the country e.g. Switzerland => CHE
        /// Three digit country codes
        /// </summary>
        [JsonProperty("abbrevation")]
        public string Abbreviation { get; set; }
    }
}
