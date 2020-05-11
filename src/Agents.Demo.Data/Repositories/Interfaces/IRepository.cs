using System.Collections.Generic;

namespace Agents.Demo.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Add(T entity);
        bool Delete(int id);
        bool Update(T entity);
        T GetById(int id);
    }
}
