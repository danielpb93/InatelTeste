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
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.country))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.WebPages, opt => opt.MapFrom(src => src.web_pages.Select(url => new WebPage { Url = url }).ToList()))
            .ForMember(dest => dest.Domains, opt => opt.MapFrom(src => src.domains.Select(name => new InatelTeste.Domain.Entities.Domain { Name = name }).ToList()));

            CreateMap<University, UniversityResponseDto>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
            .ForMember(dest => dest.Domains, opt => opt.MapFrom(src => src.Domains.Select(d => d.Name).ToList()))
            .ForMember(dest => dest.WebPages, opt => opt.MapFrom(src => src.WebPages.Select(w => w.Url).ToList()));
        }
    }
}