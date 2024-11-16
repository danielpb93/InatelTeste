using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Domain.Entities
{
    public class University
    {
        public Guid Id { get; set; }
        public string WebPage { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Domain { get; set; } = null!;
        public string Name { get; set; } = null!;

        public University()
        {
            Id = Guid.NewGuid();
        }

        public University(string name, string country, string domain, string webPage) : base()
        {
            Name = name;
            Country = country;
            Domain = domain;
            WebPage = webPage;
        }
    }
}