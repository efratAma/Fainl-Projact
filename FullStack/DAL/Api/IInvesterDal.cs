using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Api
{
    internal interface IInvesterDal
    {
        void AddInvester(Investor invester);
    }
}
