using AutoMapper;
using GG.Dion.Application.Interfaces;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public Task<Customer> AddAsync(CustomerViewModel customerViewModel)
        {
            var customer = Mapper.Map<Customer>(customerViewModel);

            return _customerService.AddAsync(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerService.GetAllAsync();
        }
    }
}
