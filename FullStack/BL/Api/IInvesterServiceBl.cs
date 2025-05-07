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
        Investor ConvertToInvesterDal(InvesterBl investerBl);
        bool AddAInvesterBl(InvesterBl investerBl);
    }
}
