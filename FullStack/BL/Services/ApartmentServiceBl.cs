using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Services;
using BL.Api;


namespace BL.Services
{
    internal class ApartmentServiceBl: IApartmentServiceBl
    {


        IApartmentDal apartmentDal;



        public ApartmentServiceBl(IApartmentDal apartmentDal)
        {
            this.apartmentDal = apartmentDal;
        }
        public bool AddApartmentBl(ApartmentBl apartmentBl)
        {
            var apartment = ConvertToApartmentDal(apartmentBl);
            apartmentDal.AddApartment(apartment);
            return true;
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
}
