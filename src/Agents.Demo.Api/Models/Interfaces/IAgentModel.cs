using Agents.Demo.Api.Models;

namespace Agents.Demo.Api.Models.Interfaces
{
    public interface IAgentModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        int Tier { get; set; }
        AgentPhoneModel Phone { get; set; }
    }

    public interface IAgentPhoneModel
    {
        string Primary { get; set; }
        string Mobile { get; set; }
    }
}
