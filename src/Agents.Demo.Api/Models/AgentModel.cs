using Agents.Demo.Api.Models.Interfaces;

namespace Agents.Demo.Api.Models
{
    public class AgentModel : IAgentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int Tier { get; set; }
        public AgentPhoneModel Phone { get; set; }
    }

    public class AgentPhoneModel : IAgentPhoneModel
    {
        public string Primary { get; set; }
        public string Mobile { get; set; }
    }
}
