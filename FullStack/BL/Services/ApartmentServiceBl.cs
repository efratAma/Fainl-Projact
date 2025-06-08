using BL.Api;
using BL.Exseption;
using DAL.Api;
using FullStack.api;

public class ApartmentServiceBl : IApartmentServiceBl
{
    private readonly IApartmentDal apartmentDal;
    private readonly IProjectDal projectDal;

    public ApartmentServiceBl(IApartmentDal apartmentDal, IProjectDal _projectDal)
    {
        this.apartmentDal = apartmentDal;
        this.projectDal = _projectDal;
    }

    public bool AddApartmentBl(ApartmentBl apartmentBl)
    {
        Apartment a = apartmentDal.GetApartmentById(apartmentBl.Id);
        if (a == null)
        {
            var apartment = ConvertToApartmentDal(apartmentBl);
            if (projectDal.GetAllProjects().FirstOrDefault(x => x.Id == apartmentBl.ProjectNumber) != null)
            {
                apartmentDal.AddApartment(apartment);
                return true;
            }
            else
            {
                throw new ExseptionBl($"Project with ID {apartmentBl.ProjectNumber} does not exist.");


            }
        }
        else
        {
            return false;
        }
    }

    public bool RemoveApartmentBl(ApartmentBl apartmentBl)
    {
        Apartment a = apartmentDal.GetApartmentById(apartmentBl.Id);
        if (a != null)
        {
            apartmentDal.RemoveApartment(a);
            return true;
        }
        return false;
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