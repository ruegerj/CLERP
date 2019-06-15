using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Features.v1.WarehouseArea.GetAll
{
    public class WarehouseGetAllResponse
    {
        [JsonProperty("warehouses")]
        public IEnumerable<WarehouseResponse> Warehouses { get; set; }
    }
}
