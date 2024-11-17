using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InatelTeste.Application.dtos;
using InatelTeste.Domain.Entities;

namespace InatelTeste.Application.profiles
{
    public class UniversityProfile : Profile
    {
        public UniversityProfile()
        {
            CreateMap<UniversityExternalAPIDto, University>()
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.WebPages, opt => opt.MapFrom(src => src.WebPages.Select(url => new WebPage { Url = url }).ToList()))
            .ForMember(dest => dest.Domains, opt => opt.MapFrom(src => src.Domains.Select(name => new InatelTeste.Domain.Entities.Domain { Name = name }).ToList()))
            .ForMember(dest => dest.StateProvince, opt => opt.MapFrom(src => src.StateProvince))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode));

            CreateMap<University, UniversityResponseDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.StateProvince, opt => opt.MapFrom(src => src.StateProvince))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            .ForMember(dest => dest.Domains, opt => opt.MapFrom(src => src.Domains.Select(d => d.Name).ToList()))
            .ForMember(dest => dest.WebPages, opt => opt.MapFrom(src => src.WebPages.Select(w => w.Url).ToList()));
        }
    }
}