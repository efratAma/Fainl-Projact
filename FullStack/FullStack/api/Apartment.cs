using System;
using System.Collections.Generic;

namespace FullStack.api;

public partial class Apartment
{
    public int Id { get; set; }

    public int SquareMeter { get; set; }

    public int ZipCode { get; set; }

    public double? NumberOfRooms { get; set; }

    public int? Floor { get; set; }

    public int? Price { get; set; }

    public int? InvesterId { get; set; }

    public int? Profit { get; set; }

    public int ProjectNumber { get; set; }

    public virtual Investor? Invester { get; set; }

    public virtual Project ProjectNumberNavigation { get; set; } = null!;
}
