using Newtonsoft.Json;

namespace Umbraco.Cheatsheet.Core.Models.ApiModels
{
    public class ProductApiModel
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }
    }
}
