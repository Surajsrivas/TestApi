using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.InfraStructure.Repositories;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Allow_api")]
    public class userDetails : ControllerBase
    {

        public readonly userRepository _context;
        public userDetails(userRepository context)
        {
            _context = context;

        }
        [HttpPost]
        [Route("SaveUserDetails")]
       
        public async Task<ActionResult<TestApi.Domain.Models.user>> SavePaymentDetails(TestApi.Domain.Models.user data)

        {
            try
            {
                if (data == null)
                    return BadRequest();

                var carddetails = await _context.AddUserDetails(data);
                return Ok();

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
               "Error creating new employee record");
            }

        }
    }
}
