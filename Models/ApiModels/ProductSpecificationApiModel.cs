using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models.ApiModels
{
    public class ProductSpecificationApiModel
    {
        [Newtonsoft.Json.JsonProperty("standart")]
        public long StandartDisanId { get; set; }
        [Newtonsoft.Json.JsonProperty("jr")]
        public long SpecificationDisanId { get; set; }
        [Newtonsoft.Json.JsonProperty("price")]
        public double Price { get; set; }
    }
}
