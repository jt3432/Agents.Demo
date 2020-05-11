using Agents.Demo.Data.Entities;
using AutoMapper;

namespace Agents.Demo.Api.Models.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Agent Mappings
            CreateMap<Agent, AgentModel>();
            CreateMap<AgentModel, Agent>();
            CreateMap<AgentPhone, AgentPhoneModel>();            
            CreateMap<AgentPhoneModel, AgentPhone>();

            //Customer Mappings
            CreateMap<Customer, CustomerModel>();
            CreateMap<CustomerModel, Customer>();
            CreateMap<Name, NameModel>();
            CreateMap<NameModel, Name>();
        }
    }
}
