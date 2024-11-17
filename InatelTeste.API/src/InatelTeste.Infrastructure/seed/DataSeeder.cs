using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InatelTeste.Application.interfaces.services;
using InatelTeste.Domain.Entities;
using InatelTeste.Domain.interfaces.repositories;
using InatelTeste.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InatelTeste.Infrastructure.seed
{
    public class DataSeeder
    {
        private readonly IUniversityRepository _universityRepository;
        private readonly ApplicationDbContext _dbContext;
        private readonly IUniversityAPIService _universityAPIService;
        private readonly ILogger<DataSeeder> _logger;
        private readonly IMapper _mapper;

        public DataSeeder(
            ApplicationDbContext dbContext,
            IUniversityRepository universityRepository,
            IUniversityAPIService universityAPIService,
            ILogger<DataSeeder> logger,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _universityAPIService = universityAPIService;
            _universityRepository = universityRepository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<bool> ApplyMigration()
        {
            try
            {
                await _dbContext.Database.MigrateAsync();
                _logger.LogInformation("Migrations aplicadas com sucesso.");
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Erro ao aplicar as migrations no banco de dados.");
                return false;
            }

        }
        public async Task SeedDatabaseAsync()
        {
            if (!await _universityRepository.AnyAsync())
            {
                var universitiesDto = await _universityAPIService.GetExternalDataAsync();
                var universities = _mapper.Map<IEnumerable<University>>(universitiesDto);

                await _universityRepository.AddRangeAsync(universities);
            }
        }
    }
}