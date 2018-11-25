using AutoMapper;
using DomailEntity.Entities;
using Mvc_Basic.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Basic.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMapFromViewModelToEntities();
            CreateMapFromViewModelToViewModels();
        }
       private void CreateMapFromViewModelToEntities() {
            CreateMap<SupplierViewModel, Supplier>()
                .ForMember(dest => dest.CreatedBy, src => src.Ignore())
                .ForMember(dest => dest.CreatedDate, src => src.Ignore())
                .ForMember(dest => dest.UpdatedDate, src => src.Ignore());
       }

        private void CreateMapFromViewModelToViewModels()
        {
            CreateMap<Supplier, SupplierViewModel>();
        }
    }
}