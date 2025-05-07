using Microsoft.AspNetCore.Mvc;
using FullStack.Controllers; 
using BL.Api;
using FullStack.api;
//using BL.Services;


namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
         IApartmentServiceBl _apartmentServiceBl;

        public ApartmentController(IApartmentServiceBl apartmentServiceBl)
        {
            _apartmentServiceBl = apartmentServiceBl;
        }

        [HttpPut]    
        public IActionResult AddApartment([FromBody] ApartmentBl apartmentBl)
        {
           if(_apartmentServiceBl.AddApartmentBl(apartmentBl))
            { 
                return Ok("Apartment added successfully");
            }
           return BadRequest("this apartment is alredy exsist");
        }
      
    }
}
