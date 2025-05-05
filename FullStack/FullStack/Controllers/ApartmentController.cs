using Microsoft.AspNetCore.Mvc;
using FullStack.Controllers; // Make sure to include the namespace for IApartmentServiceBl
using BL.Services; // Assuming APartmentsServiceBl is from this namespace
using BL.Api;


namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentServiceBl _apartmentServiceBl;

        public ApartmentController(IApartmentServiceBl apartmentServiceBl)
        {
            _apartmentServiceBl = apartmentServiceBl;
        }

        [HttpPut]    
        public IActionResult AddApartment([FromBody] )
        {

        }
    }
}
