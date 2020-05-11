using System;

namespace Agents.Demo.Data.Entities.Interfaces
{
    public interface IAgentEntity : IEntity
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }
        int Tier { get; set; }
        AgentPhone Phone { get; set; }
    }

    public interface IAgentPhoneEntity
    {
        string Primary { get; set; }
        string Mobile { get; set; }
    }
}
