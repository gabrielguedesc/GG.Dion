using AutoMapper;
using GG.Dion.Application.Interfaces;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public Task<Customer> AddAsync(CustomerViewModel customerViewModel)
        {
            return _customerService.AddAsync(_mapper.Map<Customer>(customerViewModel));
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerService.GetAllAsync();
        }

        public Task<Customer> UpdateAsync(CustomerViewModel customerViewModel)
        {
            return _customerService.UpdateAsync(_mapper.Map<Customer>(customerViewModel));
        }
    }
}
