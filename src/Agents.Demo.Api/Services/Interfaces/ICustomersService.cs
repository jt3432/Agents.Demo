using Agents.Demo.Api.Models.Interfaces;
using System.Collections.Generic;

namespace Agents.Demo.Api.Services.Interfaces
{
    public interface ICustomersService : IServiceBase<ICustomerModel>
    {
        IEnumerable<ICustomerModel> GetCustomersByAgentId(int id);
    }
}
