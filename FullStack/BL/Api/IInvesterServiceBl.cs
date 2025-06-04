using BL.Models;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IInvesterServiceBl
    {
        Investor ConvertToInvestorDal(InvesterBl investerBl);
        bool AddAInvestorBl(InvesterBl investerBl);
        bool RemoveInvestorBl(InvesterBl investerBl);
        List<InvesterBl> GetAllInvestorsBl();
    }
}
