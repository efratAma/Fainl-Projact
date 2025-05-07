using BL.Api;
using DAL.Api;
using FullStack.api;

public class ApartmentServiceBl : IApartmentServiceBl
{
    private readonly dbClass dbClass;
    private readonly IApartmentDal apartmentDal;

    public ApartmentServiceBl(IApartmentDal apartmentDal, dbClass dbClass)
    {
        this.apartmentDal = apartmentDal;
        this.dbClass = dbClass;
    }

    public bool AddApartmentBl(ApartmentBl apartmentBl)
    {
        Apartment a = dbClass.Apartments.FirstOrDefault(x => x.Id == apartmentBl.Id);
        if (a == null)
        {
            var apartment = ConvertToApartmentDal(apartmentBl);
            apartmentDal.AddApartment(apartment);
            return true;
        }
        else
        {
            return false;
        }
    }

    public Apartment ConvertToApartmentDal(ApartmentBl apartmentBl)
    {
        return new Apartment
        {
            Id = apartmentBl.Id,
            SquareMeter = apartmentBl.SquareMeter,
            ZipCode = apartmentBl.ZipCode,
            NumberOfRooms = apartmentBl.NumberOfRooms,
            Floor = apartmentBl.Floor,
            Price = apartmentBl.Price,
            InvesterId = apartmentBl.InvesterId,
            Profit = apartmentBl.Profit,
            ProjectNumber = apartmentBl.ProjectNumber
        };
    }
}