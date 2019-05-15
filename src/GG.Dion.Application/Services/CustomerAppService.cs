using AutoMapper;
using GG.Dion.Application.Interfaces;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;
using GG.Dion.Domain.Interfaces.Services;
using GG.Dion.Infra.Data.UoW;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GG.Dion.Application.Services
{
    public class CustomerAppService : BaseService, ICustomerAppService
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService, IMapper mapper, IUnitOfWork uow) : base(uow)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<Customer> AddAsync(CustomerViewModel customerViewModel)
        {
            var result = await _customerService.AddAsync(_mapper.Map<Customer>(customerViewModel));

            if (result.ValidationResult.IsValid)
                Commit();

            return result;
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customerService.GetAllAsync();
        }

        public async Task<Customer> UpdateAsync(CustomerViewModel customerViewModel)
        {
            var result = await _customerService.UpdateAsync(_mapper.Map<Customer>(customerViewModel));

            if (result.ValidationResult.IsValid)
                Commit();

            return result;
        }
    }
}
