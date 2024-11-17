using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Domain.Entities
{
    public class University
    {
        public int Id { get; set; }
        public List<WebPage> WebPages { get; set; } = new List<WebPage>();
        public string Country { get; set; } = null!;
        public List<Domain> Domains { get; set; } = new List<Domain>();
        public string Name { get; set; } = null!;
        public string? StateProvince { get; set; }
        public string? CountryCode { get; set; }
    }
}