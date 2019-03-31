using GG.Dion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Domain.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<Customer> AddAsync(Customer customer);
        Task<Customer> GetByIdAsync(Guid id);
        Task<Customer> UpdateAsync(Customer customer);
        Task<IEnumerable<Customer>> GetAllAsync();
        Task RemoveAsync(Guid id);
    }
}
