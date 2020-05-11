using Agents.Demo.Data.Entities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Agents.Demo.Data.Entities
{
    public class Customer : ICustomerEntity
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("agent_id")]
        public int AgentId { get; set; }

        [JsonProperty("guid")]
        public Guid AgentGuid { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("eyeColor")]
        public string EyeColor { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("registered")]
        public DateTime Registered { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("tags")]
        public IEnumerable<string> Tags { get; set; }
    }

    public class Name : INameEntity
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }
}
