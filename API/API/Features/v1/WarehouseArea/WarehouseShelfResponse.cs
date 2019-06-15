using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Response dto for shelf data inside a request targeting the warehouse controller
    /// </summary>
    public class WarehouseShelfResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// Designation of the shelf e.g. shelf 7A
        /// </summary>
        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("warehouseId")]
        public Guid WarehouseGuid { get; set; }

        [JsonProperty("compartments")]
        public IEnumerable<WarehouseCompartmentResponse> Compartments { get; set; }
    }
}
