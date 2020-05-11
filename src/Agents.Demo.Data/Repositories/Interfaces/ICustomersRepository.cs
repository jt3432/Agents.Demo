using Agents.Demo.Data.Entities;
using Agents.Demo.Data.Entities.Interfaces;
using System.Collections.Generic;

namespace Agents.Demo.Data.Repositories.Interfaces
{
    public interface ICustomersRepository : IRepository<ICustomerEntity>
    {
        IEnumerable<ICustomerEntity> GetCustomerByAgentId(int id);
    }
}
