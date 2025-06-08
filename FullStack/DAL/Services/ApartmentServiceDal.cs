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
    public void RemoveApartment(Apartment apartment)
    {
        dbClass.Apartments.Remove(apartment);
        dbClass.SaveChanges();
    }
    public Apartment GetApartmentById(int id) 
    {
        return dbClass.Apartments.FirstOrDefault(x => x.Id == id);
    }
}
