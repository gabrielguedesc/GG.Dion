using AutoMapper;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;

namespace GG.Dion.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}
