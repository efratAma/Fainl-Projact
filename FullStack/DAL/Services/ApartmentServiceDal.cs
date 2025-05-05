using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    internal class ApartmentServiceDal: IApartmentDal
    {
        dbClass dbClass;
        public void AddApartment(Apartment apartment)
        {
            dbClass.Apartments.Add(apartment);
            dbClass.SaveChanges();
        }
        public ApartmentServiceDal()
        {
            
        }
    }
}
