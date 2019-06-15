using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Response dto for adress data inside a request targeting the warehouse controller
    /// </summary>
    public class WarehouseAddressResponse
    {
        [JsonProperty("id")]
        public Guid AddressGuid { get; set; }

        /// <summary>
        /// The street name without the house-number
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The housenumber , can be null if non existing
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Include, PropertyName = "housenumber")]
        public int? Housenumber { get; set; }

        [JsonProperty("cityId")]
        public Guid CityGuid { get; set; }

        [JsonProperty("city")]
        public WarehouseCityResponse City { get; set; }
    }
}
