using BL.Api;
using BL.Models;
using BL.Services;
using FullStack.api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private readonly IInvesterServiceBl _investorServiceBl;

        public InvestorController(IInvesterServiceBl investorServiceBl)
        {
            _investorServiceBl = investorServiceBl;
        }
        
        [HttpPut("addInvestor")]
        public IActionResult AddInvestor([FromBody] InvesterBl InvesterBl)
        {
            if (_investorServiceBl.AddAInvesterBl(InvesterBl))
            {
                return Ok("Investor added successfully");
            }
            return BadRequest("this Investor is alredy exsist");
        }
      
    }
}
