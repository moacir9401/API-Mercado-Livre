using Newtonsoft.Json;
public class AvailableFilter
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
