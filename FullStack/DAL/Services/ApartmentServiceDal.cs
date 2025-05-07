using DAL.Api;
using FullStack.api;

public class ApartmentServiceDal : IApartmentDal
{
    private readonly dbClass dbClass;

    public ApartmentServiceDal(dbClass dbClass)
    {
        this.dbClass = dbClass;
    }

    public void AddApartment(Apartment apartment)
    {
        dbClass.Apartments.Add(apartment);
        dbClass.SaveChanges();
    }
}
