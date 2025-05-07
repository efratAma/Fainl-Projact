using BL.Api;
using BL.Models;
using FullStack.api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        IInvesterServiceBl _investorServiceBl;
        [HttpPut]
        public IActionResult AddApartment([FromBody] InvesterBl InvesterBl)
        {
            if (_investorServiceBl.AddAInvesterBl(InvesterBl))
            {
                return Ok("Apartment added successfully");
            }
            return BadRequest("this apartment is alredy exsist");
        }
      
    }
}
