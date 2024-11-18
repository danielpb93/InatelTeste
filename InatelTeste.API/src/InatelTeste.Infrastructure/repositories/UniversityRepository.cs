using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InatelTeste.Domain.Entities;
using InatelTeste.Domain.interfaces.repositories;
using InatelTeste.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InatelTeste.Infrastructure.repositories
{
    public class UniversityRepository : IUniversityRepository
    {
        private readonly ApplicationDbContext _context;

        public UniversityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddRangeAsync(IEnumerable<University> entities)
        {
            await _context.University.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<University>> GetAllAsync() =>
            await _context.University
                .Include(u => u.WebPages)
                .Include(u => u.Domains)
                .Take(10)
                .ToListAsync();

        public async Task<IEnumerable<University>> GetAllByCountryAsync(string country) =>
            await _context.University
                .Include(u => u.WebPages)
                .Include(u => u.Domains)
                .Where(u => u.Country.ToLower() == country.ToLower())
                .ToListAsync();

        public async Task<bool> AnyAsync() =>
            await _context.University.AnyAsync();

    }
}