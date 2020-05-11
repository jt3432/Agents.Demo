using Agents.Demo.Data.Entities;
using Agents.Demo.Data.Entities.Interfaces;
using Agents.Demo.Data.Repositories.Interfaces;
using JsonFlatFileDataStore;
using System.Collections.Generic;
using System.Linq;

namespace Customers.Demo.Data.Repositories
{
    public class CustomersJsonRepository : ICustomersRepository
    {
        private readonly string _jsonDataStoreFilePath;
        private IDataStore _ds; 

        public CustomersJsonRepository(string jsonDataStoreFilePath)
        {
            _jsonDataStoreFilePath = jsonDataStoreFilePath;
            _ds = new DataStore(_jsonDataStoreFilePath);
        }

        public ICustomerEntity Add(ICustomerEntity entity)
        {
            var collection = _ds.GetCollection<Customer>();

            entity.Id = collection.AsQueryable().Max(a => a.Id) + 1;

            collection.InsertOne((Customer)entity);

            return entity;
        }

        public bool Delete(int id)
        {
            var collection = _ds.GetCollection<Customer>();
            return collection.DeleteOne(id);
        }

        public IEnumerable<ICustomerEntity> GetAll()
        {
            return _ds.GetCollection<Customer>().AsQueryable();
        }

        public ICustomerEntity GetById(int id)
        {
            var collection = _ds.GetCollection<Customer>();
            return collection.AsQueryable().FirstOrDefault(a => a.Id.Equals(id) == true);
        }

        public bool Update(ICustomerEntity entity)
        {
            var collection = _ds.GetCollection<Customer>();
            return collection.UpdateOne(entity.Id, (Customer)entity);
        }

        public IEnumerable<ICustomerEntity> GetCustomerByAgentId(int id)
        {
            var collection = _ds.GetCollection<Customer>();
            return collection.AsQueryable().Where(c => c.AgentId.Equals(id) == true);
        }
    }
}
