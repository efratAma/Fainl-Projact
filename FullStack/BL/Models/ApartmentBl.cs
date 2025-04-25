using DAL.Api;
using System;
using System.Collections.Generic;

namespace FullStack.api;

public partial class ApartmentBl
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
    
    public ApartmentBl(int id, int squaremeter, int zipCode, double numberOfRoom, int floor, int price, int investerId, int profit, int projectNumber)
    {       
        Id = id;
        SquareMeter = squaremeter;
        ZipCode = zipCode;
        NumberOfRooms= numberOfRoom;
        Floor = floor;
        Price = price;
        InvesterId = investerId;
        Profit = profit;
        ProjectNumber = projectNumber;
    }
}
