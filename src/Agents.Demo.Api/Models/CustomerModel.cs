using Agents.Demo.Api.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Agents.Demo.Api.Models
{
    public class CustomerModel : ICustomerModel
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public Guid AgentGuid { get; set; }
        public bool IsActive { get; set; }
        public string Balance { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public NameModel Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Registered { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }

    public class NameModel : INameModel
    {
        public string First { get; set; }
        public string Last { get; set; }
    }
}
