using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InatelTeste.Application.dtos;
using InatelTeste.Application.interfaces.services;
using InatelTeste.Domain.interfaces.repositories;
using Microsoft.AspNetCore.Mvc;

namespace InatelTeste.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UniversityController : ControllerBase
    {
        private readonly IUniversityRepository _universityRepository;
        private readonly IMapper _mapper;

        public UniversityController(IUniversityRepository universityRepository, IMapper mapper)
        {
            _universityRepository = universityRepository;
            _mapper = mapper;
        }
        [HttpGet("{country}")]
        public async Task<IActionResult> GetUniversitiesByCountry([FromRoute] string country, [FromQuery] string? name)
        {
            var universidades = await _universityRepository.GetAllByCountryAsync(country, name);
            var result = _mapper.Map<IEnumerable<UniversityResponseDto>>(universidades);
            return Ok(result);
        }
    }
}