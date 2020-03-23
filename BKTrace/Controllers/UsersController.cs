using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BKTrace.Models;
using BKTrace.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BKTrace.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userService.authenticate(model.user_name, model.password);
            if(user == null)
            {
                return BadRequest(new { message = "Username or password is incorect!" });
            }

            return Ok(user);
        }

        [HttpGet]
        public string pass()
        {
            return "hello";
        }
    }
}