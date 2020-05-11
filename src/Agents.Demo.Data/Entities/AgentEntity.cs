using Agents.Demo.Data.Entities.Interfaces;
using Newtonsoft.Json;

namespace Agents.Demo.Data.Entities
{
    public class Agent : IAgentEntity
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("tier")]
        public int Tier { get; set; }

        [JsonProperty("phone")]
        public AgentPhone Phone { get; set; }
    }

    public class AgentPhone : IAgentPhoneEntity
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    }
}
