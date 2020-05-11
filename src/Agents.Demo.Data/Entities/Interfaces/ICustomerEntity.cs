using System;
using System.Collections.Generic;

namespace Agents.Demo.Data.Entities.Interfaces
{
    public interface ICustomerEntity : IEntity
    {
        int AgentId { get; set; }
        Guid AgentGuid { get; set; }
        bool IsActive { get; set; }
        string Balance { get; set; }
        int Age { get; set; }
        string EyeColor { get; set; }
        Name Name { get; set; }
        string Company { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        DateTime Registered { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        IEnumerable<string> Tags { get; set; }
    }

    public interface INameEntity
    {
        string First { get; set; }
        string Last { get; set; }
    }
}
