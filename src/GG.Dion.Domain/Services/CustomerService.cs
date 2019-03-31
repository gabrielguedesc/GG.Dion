using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Repositories;
using GG.Dion.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            if (!customer.IsValidForNewRegister())
                return customer;

            return await _customerRepository.AddAsync(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }

        public async Task<Customer> GetByIdAsync(Customer customer)
        {
            return await _customerRepository.GetByIdAsync(customer.Id);
        }

        public async Task<Customer> RemoveAsync(Customer customer)
        {
            if (!customer.IsValidForRemove())
                return customer;

            return await _customerRepository.RemoveAsync(customer);
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            if (!customer.IsValidForUpdate())
                return customer;

            return await _customerRepository.UpdateAsync(customer);
        }
    }
}
