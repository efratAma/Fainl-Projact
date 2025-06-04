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
            if (_investorServiceBl.AddAInvestorBl(InvesterBl))
            {
                return Ok("Investor added successfully");
            }
            return BadRequest("this Investor is alredy exsist");
        }
        [HttpDelete("removeInvestor")]
        public IActionResult RemoveInvestor([FromBody] InvesterBl InvesterBl)
        {
            if (_investorServiceBl.RemoveInvestorBl(InvesterBl))
            {
                return Ok("Investor removed successfully");
            }
            return BadRequest("this Investor is not exsist");
        }
        [HttpGet("getAllInvestors")]
        public IActionResult GetAllInvestors()
        {
            List<InvesterBl> investors = _investorServiceBl.GetAllInvestorsBl();
            if (investors != null && investors.Count > 0)
            {
                return Ok(investors);
            }
            return NotFound("No investors found");
        }

        }
}
