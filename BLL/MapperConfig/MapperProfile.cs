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
                .ForMember(a => a.Level, src => src.MapFrom(a => a.ToxicityLevel))
                .ReverseMap()
                .ForPath(a => a.Name, opt => opt.MapFrom(src => src.Name))
                .ForPath(a => a.ToxicityLevel, opt => opt.MapFrom(src => src.Level));

            CreateMap<LockerDTO, Locker>()
                .ForMember(a => a.Level, src => src.MapFrom(a => a.ToxicityLevel))
                .ForMember(a => a.Capacity, src => src.MapFrom(a => a.Capacity))
                .ReverseMap()
                .ForPath(a => a.ToxicityLevel, src => src.MapFrom(a => a.Level))
                .ForPath(a => a.Capacity, src => src.MapFrom(a => a.Capacity));
        }
    }
}
