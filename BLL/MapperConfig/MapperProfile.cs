using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.MapperConfig
{
    class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BooksDTO, Books>()
                .ForMember(a => a.Name, src => src.MapFrom(a => a.Name))
                .ForMember(a => a.Theme, src => src.MapFrom(a => a.Theme))
                .ReverseMap()
                .ForPath(a => a.Name, opt => opt.MapFrom(src => src.Name))
                .ForPath(a => a.Theme, opt => opt.MapFrom(src => src.Theme));

            CreateMap<LockerDTO, Locker>()
                .ForMember(a => a.Theme, src => src.MapFrom(a => a.Theme))
                .ForMember(a => a.Capacity, src => src.MapFrom(a => a.Capacity))
                .ReverseMap()
                .ForPath(a => a.Theme, src => src.MapFrom(a => a.Theme))
                .ForPath(a => a.Capacity, src => src.MapFrom(a => a.Capacity));
        }
    }
}
