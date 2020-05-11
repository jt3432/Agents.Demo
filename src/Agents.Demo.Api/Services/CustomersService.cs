using Agents.Demo.Api.Models;
using Agents.Demo.Api.Models.Interfaces;
using Agents.Demo.Api.Services.Interfaces;
using Agents.Demo.Data.Entities;
using Agents.Demo.Data.Repositories.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace Agents.Demo.Api.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepository _repo;
        private readonly IMapper _mapper;
        public CustomersService(ICustomersRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public ICustomerModel Add(ICustomerModel model)
        {
            var customer = _mapper.Map<Customer>(model);
            return _mapper.Map<CustomerModel>(_repo.Add(customer));
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public ICustomerModel Get(int id)
        {
            var customer = _repo.GetById(id);
            return _mapper.Map<CustomerModel>(customer);
        }

        public IEnumerable<ICustomerModel> GetAll()
        {
            var customers = _repo.GetAll();
            return _mapper.Map<IEnumerable<CustomerModel>>(customers);
        }

        public bool Update(ICustomerModel model)
        {
            var customer = _mapper.Map<Customer>(model);
            return _repo.Update(customer);
        }

        public IEnumerable<ICustomerModel> GetCustomersByAgentId(int id)
        {
            var customers = _repo.GetCustomerByAgentId(id);
            return _mapper.Map<IEnumerable<CustomerModel>>(customers);
        }
    }
}
