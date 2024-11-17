using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InatelTeste.Application.dtos
{
    public class UniversityExternalAPIDto
    {
        [JsonPropertyName("web_pages")]
        public List<string> WebPages { get; set; } = new List<string>();
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("domains")]
        public List<string> Domains { get; set; } = new List<string>();
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("alpha_two_code")]
        public string? CountryCode { get; set; }
        [JsonPropertyName("state-province")]
        public string? StateProvince { get; set; }
    }
}