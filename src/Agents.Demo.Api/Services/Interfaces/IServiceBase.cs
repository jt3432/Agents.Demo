using System.Collections.Generic;

namespace Agents.Demo.Api.Services.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Add(T model);
        T Get(int id);
        bool Delete(int id);
        bool Update(T model);
    }
}
