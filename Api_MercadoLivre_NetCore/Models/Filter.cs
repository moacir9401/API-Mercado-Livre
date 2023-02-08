using Newtonsoft.Json;
public class Filter
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("type")]
        public string Type;

        [JsonProperty("values")]
        public List<Value> Values;
    }
