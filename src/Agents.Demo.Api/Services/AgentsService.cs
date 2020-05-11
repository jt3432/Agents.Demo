using Agents.Demo.Api.Models;
using Agents.Demo.Api.Models.Interfaces;
using Agents.Demo.Api.Services.Interfaces;
using Agents.Demo.Data.Entities;
using Agents.Demo.Data.Repositories.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace Agents.Demo.Api.Services
{
    public class AgentsService : IAgentsService
    {
        private readonly IAgentsRepository _repo;
        private readonly IMapper _mapper;
        public AgentsService(IAgentsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IAgentModel Add(IAgentModel model)
        {
            var agent = _mapper.Map<Agent>(model);
            return _mapper.Map<AgentModel>(_repo.Add(agent));
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public IAgentModel Get(int id)
        {
            var agent = _repo.GetById(id);
            return _mapper.Map<AgentModel>(agent);
        }

        public IEnumerable<IAgentModel> GetAll()
        {
            var agents = _repo.GetAll();
            return _mapper.Map<IEnumerable<AgentModel>>(agents);
        }

        public bool Update(IAgentModel model)
        {
            var agent = _mapper.Map<Agent>(model);
            return _repo.Update(agent);
        }                
    }
}
