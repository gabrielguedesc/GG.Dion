using AutoMapper;
using GG.Dion.Application.ViewModels;
using GG.Dion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GG.Dion.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}
