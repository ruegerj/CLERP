using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea
{
    /// <summary>
    /// Response dto for compartment data inside a request targeting the warehouse controller
    /// </summary>
    public class WarehouseCompartmentResponse
    {
        [JsonProperty("id")]
        public Guid Guid { get; set; }

        /// <summary>
        /// The row number inside the compartment grid
        /// </summary>
        [JsonProperty("row")]
        public int Row { get; set; }

        /// <summary>
        /// The column number inside the compartment grid
        /// </summary>
        [JsonProperty("column")]
        public int Column { get; set; }
        
        [JsonProperty("shelfId")]
        public Guid ShelfGuid { get; set; }
    }
}
