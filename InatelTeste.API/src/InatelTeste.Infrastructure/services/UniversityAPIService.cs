using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using InatelTeste.Application.dtos;
using InatelTeste.Application.interfaces.services;

namespace InatelTeste.Infrastructure.services
{
    public class UniversityAPIService : IUniversityAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UniversityAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<UniversityExternalAPIDto>> GetExternalDataAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("UniversityApi"); // "ExternalApi" é o nome do cliente configurado

            var response = await httpClient.GetAsync("/search");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao carregar os dados da University API");
            }

            var content = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(content))
                return new List<UniversityExternalAPIDto>();

            return JsonSerializer.Deserialize<IEnumerable<UniversityExternalAPIDto>>(content)!;
        }
    }
}