using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Domain.Entities
{
    public class WebPage
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int UniversityId { get; set; }
        public University University { get; set; } = null!;
    }
}