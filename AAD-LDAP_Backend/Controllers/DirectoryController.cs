using AAD_LDAP_Backend.Entitys;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.DirectoryServices;
using AAD_LDAP_Backend.Context;

namespace AAD_LDAP_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectoryController : ControllerBase
    {
        private readonly InterFace _context;

        public DirectoryController(InterFace context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult ReadAllUsers()
        {
            var res = _context.ReadAllUsers();
            return Ok(res);
        }

    }
}
