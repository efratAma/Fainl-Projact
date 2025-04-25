using System;
using System.Collections.Generic;

namespace FullStack.api;

public partial class Investor
{
    
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int InvestmentAmount { get; set; }

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();
}
