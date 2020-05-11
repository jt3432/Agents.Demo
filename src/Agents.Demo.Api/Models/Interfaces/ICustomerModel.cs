using Agents.Demo.Api.Models;
using System;
using System.Collections.Generic;

namespace Agents.Demo.Api.Models.Interfaces
{
    public interface ICustomerModel
    {
        int AgentId { get; set; }
        Guid AgentGuid { get; set; }
        bool IsActive { get; set; }
        string Balance { get; set; }
        int Age { get; set; }
        string EyeColor { get; set; }
        NameModel Name { get; set; }
        string Company { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        DateTime Registered { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        IEnumerable<string> Tags { get; set; }
    }

    public interface INameModel
    {
        string First { get; set; }
        string Last { get; set; }
    }
}
