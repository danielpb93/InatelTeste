using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InatelTeste.Domain.Entities;

namespace InatelTeste.Domain.interfaces.repositories
{
    public interface IUniversityRepository
    {
        Task AddRangeAsync(IEnumerable<University> entities);
        Task<IEnumerable<University>> GetAllAsync();
        Task<bool> AnyAsync();
    }
}