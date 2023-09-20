namespace HexDemo.RestAdapter
{
    using System.Runtime.InteropServices;
    using HexDemo.Domain.Ports;
    using Microsoft.AspNetCore.Mvc;
    using Application.Domain.Services;

    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserDetailService _userDetails;
        public UserController(IUserDetailService userDetails)
        {
            _userDetails = userDetails;
        }
        // GET: api/deal
        [HttpGet]
        public IActionResult Get()
        {
            var result = _userDetails.GetUsers();
            return Ok(result);
        }
    }
}