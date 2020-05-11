using Agents.Demo.Data.Entities;
using Agents.Demo.Data.Entities.Interfaces;
using Agents.Demo.Data.Repositories.Interfaces;
using JsonFlatFileDataStore;
using System.Collections.Generic;
using System.Linq;

namespace Agents.Demo.Data.Repositories
{
    public class AgentsJsonRepository : IAgentsRepository
    {
        private readonly string _jsonDataStoreFilePath;
        private IDataStore _ds; 

        public AgentsJsonRepository(string jsonDataStoreFilePath)
        {
            _jsonDataStoreFilePath = jsonDataStoreFilePath;
            _ds = new DataStore(_jsonDataStoreFilePath);
        }

        public IAgentEntity Add(IAgentEntity entity)
        {
            var collection = _ds.GetCollection<Agent>();

            entity.Id = collection.AsQueryable().Max(a => a.Id) + 1;

            collection.InsertOne((Agent)entity);

            return entity;
        }

        public bool Delete(int id)
        {
            var collection = _ds.GetCollection<Agent>();
            return collection.DeleteOne(id);
        }

        public IEnumerable<IAgentEntity> GetAll()
        {
            return _ds.GetCollection<Agent>().AsQueryable();
        }

        public IAgentEntity GetById(int id)
        {
            var collection = _ds.GetCollection<Agent>();
            return collection.AsQueryable().FirstOrDefault(a => a.Id.Equals(id) == true);
        }

        public bool Update(IAgentEntity entity)
        {
            var collection = _ds.GetCollection<Agent>();
            return collection.UpdateOne(entity.Id, (Agent)entity);
        }
    }
}
