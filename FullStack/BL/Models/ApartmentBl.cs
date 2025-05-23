﻿using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;

namespace FullStack.api;

public partial class ApartmentBl
{
    IApartmentDal Apartment;
    public int Id { get; set; }

    public int SquareMeter { get; set; }

    public int ZipCode { get; set; }

    public double? NumberOfRooms { get; set; }

    public int? Floor { get; set; }

    public int? Price { get; set; }

    public int? InvesterId { get; set; }

    public int? Profit { get; set; }

    public int ProjectNumber { get; set; }
    
    public ApartmentBl()
    {
       
    }
}
