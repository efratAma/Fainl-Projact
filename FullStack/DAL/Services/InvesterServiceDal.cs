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
        public InvesterServiceDal(dbClass _dbclass)
        {
            dbclass = _dbclass;
        }
        public Investor getInvestorById(int id)
        {
            return dbclass.Investors.FirstOrDefault(i => i.Id == id);
        }

        public void AddInvestor(Investor invester)
        {
            dbclass.Investors.Add(invester);
            dbclass.SaveChanges();
        }
        public void RemoveInvestor(Investor invester)
        {
            dbclass.Investors.Remove(invester);
            dbclass.SaveChanges();
        }
        public List<Investor> GetAllInvestors()
        {
            return dbclass.Investors.ToList();
        }
        public Investor ShowPersonalArea(int id)
        {
            return dbclass.Investors.FirstOrDefault(i => i.Id == id);
        }
        }
}
