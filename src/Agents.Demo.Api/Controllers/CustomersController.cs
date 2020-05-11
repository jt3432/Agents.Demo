using Agents.Demo.Api.Services.Interfaces;
using Agents.Demo.Api.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Customers.Demo.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customerService;
        public CustomersController(ICustomersService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/v1/Customers
        [HttpGet]
        public IEnumerable<ICustomerModel> Get()
        {
            return _customerService.GetAll();
        }

        // GET: api/v1/Customers/5
        [HttpGet("{id}", Name = "GetCustomer")]
        public ICustomerModel Get(int id)
        {
            return _customerService.Get(id);
        }

        // POST: api/v1/Customers
        [HttpPost]
        public void Post([FromBody] ICustomerModel value)
        {
            _customerService.Add(value);
        }

        // PUT: api/v1/Customers/5
        [HttpPut()]
        public void Put([FromBody] ICustomerModel value)
        {
            _customerService.Update(value);
        }

        // DELETE: api/v1/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }

        [HttpGet("agent/{id}", Name = "GetCustomerByAgent")]
        public IEnumerable<ICustomerModel> GetByAgent(int id)
        {
            return _customerService.GetCustomersByAgentId(id);
        }
    }
}
