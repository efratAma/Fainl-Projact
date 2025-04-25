using System;
using System.Collections.Generic;

namespace FullStack.api;

public partial class Project
{
    public int Id { get; set; }

    public string? ProjactName { get; set; }

    public int? NumberOfApartments { get; set; }

    public string? City { get; set; }

    public int ZipCode { get; set; }

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
}
