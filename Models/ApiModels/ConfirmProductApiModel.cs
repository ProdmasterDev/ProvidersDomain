using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models.ApiModels
{
    public class ConfirmProductApiModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("disanId")]
        public long DisanId { get; set; }
        [JsonProperty("verified")]
        public bool IsVerified { get; set; }
    }
}
