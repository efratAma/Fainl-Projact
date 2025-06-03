using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class ProjectBl
    {
        public int Id { get; set; }

        public string? ProjactName { get; set; }

        public int? NumberOfApartments { get; set; }

        public string? City { get; set; }

        public int ZipCode { get; set; }

    }
}
