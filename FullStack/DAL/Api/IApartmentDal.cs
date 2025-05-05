using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    public interface IApartmentDal
    {
        void AddApartment(Apartment apartment);
    }
}
