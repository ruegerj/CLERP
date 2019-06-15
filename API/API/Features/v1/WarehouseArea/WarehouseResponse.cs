using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Default response dto for a warehouse
    /// </summary>
    public class WarehouseResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shelves")]
        public IEnumerable<WarehouseShelfResponse> Shelves { get; set; }

        [JsonProperty("address")]
        public WarehouseAddressResponse Address { get; set; }
    }
}
