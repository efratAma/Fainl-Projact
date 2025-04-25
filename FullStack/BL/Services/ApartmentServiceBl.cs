using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DAL.Services;
namespace BL.Services
{
    internal class ApartmentServiceBl
    {
        ApartmentBl Apartment;
        IApartment apartmentDal;
        
        public bool AddApartmentBl(ApartmentBl apartmentBl)
        {
            
            apartmentDal.AddApartment((Apartment)Apartment);


        }
        public Apartment converToApartmentDal(ApartmentBl apartmentBl)
        {

        }
    }
}
