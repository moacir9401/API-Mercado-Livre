using Newtonsoft.Json;
public class Paging
    {
        [JsonProperty("total")]
        public int? Total;

        [JsonProperty("primary_results")]
        public int? PrimaryResults;

        [JsonProperty("offset")]
        public int? Offset;

        [JsonProperty("limit")]
        public int? Limit;
    }
