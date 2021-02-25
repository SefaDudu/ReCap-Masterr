using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult getall()
        {
            var result = _userService.GetAll();
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success) { return Ok(result); }
            return BadRequest(result);
        }
    }
}
