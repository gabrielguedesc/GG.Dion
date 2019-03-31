using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Application.Interfaces
{
    public interface ICustomerAppService
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> AddAsync(CustomerViewModel customerViewModel);
    }
}
