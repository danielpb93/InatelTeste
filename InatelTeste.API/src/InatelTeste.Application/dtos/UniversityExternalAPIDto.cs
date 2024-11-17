using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InatelTeste.Application.dtos
{
    public class UniversityExternalAPIDto
    {
        public List<string> web_pages { get; set; } = new List<string>();
        public string country { get; set; }
        public List<string> domains { get; set; } = new List<string>();
        public string name { get; set; }
    }
}