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
        private readonly IInvesterDal investerDal;

        public InvesterServiceBl(IInvesterDal InvesterDal)
        {
            this.investerDal = InvesterDal;
            
        }
        public bool AddAInvestorBl(InvesterBl investerBl)
        {
            Investor a = investerDal.getInvestorById(investerBl.Id);
            if (a == null)
            {
                var Investor = ConvertToInvestorDal(investerBl);
                investerDal.AddInvestor(Investor);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveInvestorBl(InvesterBl investerBl)
        {
            Investor a = investerDal.getInvestorById(investerBl.Id);
            if (a != null)
            {
                investerDal.RemoveInvestor(a);
                return true;
            }
            return false;
        }


        public Investor ConvertToInvestorDal(InvesterBl investerBl)
        {

            return new Investor
            {
                Id = investerBl.Id,
                FirstName = investerBl.FirstName,
                LastName = investerBl.LastName,
                InvestmentAmount = investerBl.InvestmentAmount

            };
        }
        
        public List<InvesterBl> GetAllInvestorsBl()
        {
            var investors = investerDal.GetAllInvestors();
            return investors.Select(i => new InvesterBl
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                InvestmentAmount = i.InvestmentAmount
            }).ToList();
        }
        public Investor ShowPersonalArea(int id,string FirstName , string LastName)
        {
            Investor a = investerDal.getInvestorById(id);
            return investerDal.ShowPersonalArea(id);
        }

        } 
    }
