using Newtonsoft.Json;

namespace Api_MercadoLivre_NetCore.Models
{
    public class Products
    {
        [JsonProperty("results")]
        public List<Result>? results { get; set; } 
    }
}