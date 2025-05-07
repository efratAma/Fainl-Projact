using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class InvesterServiceDal: IInvesterDal
    {
        dbClass dbclass;

       public void AddInvestor(Investor invester)
        {
            dbclass.Investors.Add(invester);

        }
    }
}
