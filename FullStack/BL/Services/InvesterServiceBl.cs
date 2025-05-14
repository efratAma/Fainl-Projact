using BL.Api;
using BL.Models;
using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class InvesterServiceBl : IInvesterServiceBl
    {
        private readonly dbClass dbClass;
        private readonly IInvesterDal investerDal;

        public InvesterServiceBl(IInvesterDal InvesterDal, dbClass dbClass)
        {
            this.investerDal = InvesterDal;
            this.dbClass = dbClass;
        }
        public bool AddAInvesterBl(InvesterBl investerBl)
        {
            Investor a = dbClass.Investors.FirstOrDefault(x => x.Id == investerBl.Id);
            if (a == null)
            {
                var Investor = ConvertToInvesterDal(investerBl);
                investerDal.AddInvestor(Investor);
                dbClass.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }


        public Investor ConvertToInvesterDal(InvesterBl investerBl)
        {

            return new Investor
            {
               Id = investerBl.Id,
                FirstName= investerBl.FirstName,
                LastName= investerBl.LastName,
                InvestmentAmount= investerBl.InvestmentAmount

            };
        }
    }
}
