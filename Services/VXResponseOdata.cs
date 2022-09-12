
using Newtonsoft.Json;

namespace ERCAJ_BANCO_proj.Services
{
    public class VXResponseOdata<T>
    {

        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public List<T> Value { get; set; }

        public bool ShouldSerializeNextLink()
        {
            return (!string.IsNullOrEmpty(NextLink));
        }
        public bool ShouldSerializeCount()
        {
            return (Count != -1);
        }
    }
}

