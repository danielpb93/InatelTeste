using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Application.dtos
{
    public class UniversityResponseDto
    {
        public List<string> WebPages { get; set; }
        public string Country { get; set; }
        public List<string> Domains { get; set; }
        public string Name { get; set; }
    }
}