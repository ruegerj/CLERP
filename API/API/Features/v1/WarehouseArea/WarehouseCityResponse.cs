using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Response dto for city data inside a request targeting the warehouse controller
    /// </summary>
    public class WarehouseCityResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public int PostalCode { get; set; }

        [JsonProperty("countryId")]
        public Guid CountryGuid { get; set; }

        [JsonProperty("country")]
        public WarehouseCountryResponse Country { get; set; }
    }
}
