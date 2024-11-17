using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InatelTeste.Application.dtos;

namespace InatelTeste.Application.interfaces.services
{
    public interface IUniversityAPIService
    {
        Task<IEnumerable<UniversityExternalAPIDto>> GetExternalDataAsync();
    }
}