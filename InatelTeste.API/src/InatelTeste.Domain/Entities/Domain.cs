using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Domain.Entities
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UniversityId { get; set; }

        public University University { get; set; } = null!;
    }
}