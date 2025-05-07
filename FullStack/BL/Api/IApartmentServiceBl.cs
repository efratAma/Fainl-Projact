using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IApartmentServiceBl
    {
        Apartment ConvertToApartmentDal(ApartmentBl apartmentBl);
        bool AddApartmentBl(ApartmentBl apartmentBl);
    }
}
