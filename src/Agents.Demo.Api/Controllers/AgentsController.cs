using Agents.Demo.Api.Services.Interfaces;
using Agents.Demo.Api.Models;
using Agents.Demo.Api.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Agents.Demo.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        private readonly IAgentsService _agentsService;
        public AgentsController(IAgentsService  agentsService)
        {
            _agentsService = agentsService;
        }

        // GET: api/v1/Agents
        [HttpGet]
        public IEnumerable<IAgentModel> Get()
        {
            return _agentsService.GetAll();
        }

        // GET: api/v1/Agents/5
        [HttpGet("{id}", Name = "GetAgent")]
        public IAgentModel Get(int id)
        {
            return _agentsService.Get(id);
        }

        // POST: api/v1/Agents
        [HttpPost]
        public IAgentModel Post([FromBody] AgentModel value)
        {
            return _agentsService.Add(value);
        }

        // PUT: api/v1/Agents/5
        [HttpPut()]
        public void Put([FromBody] AgentModel value)
        {
            _agentsService.Update(value);
        }

        // DELETE: api/v1/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _agentsService.Delete(id);
        }
    }
}
