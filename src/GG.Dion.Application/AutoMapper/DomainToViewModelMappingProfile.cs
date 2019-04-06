using AutoMapper;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;

namespace GG.Dion.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
