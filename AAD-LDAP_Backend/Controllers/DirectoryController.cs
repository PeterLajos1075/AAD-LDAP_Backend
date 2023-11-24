using AAD_LDAP_Backend.Entitys;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.DirectoryServices;
using AAD_LDAP_Backend.Context;
using Newtonsoft.Json;

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

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> ReadByName([FromRoute] string name)
        {
            var User = _context.ReadByName(name);
            if (User == null)
            {
                return NotFound();
            }
            return Ok(User);
        }

        [HttpGet]
        [Route("external")]
        public async Task<IActionResult> ReadExtUsers()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            
            HttpClient client = new HttpClient(handler);
            HttpResponseMessage response = await client.GetAsync("https://auth.hungaria.koerber.de/AllUsers/get-all");
            
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var ext = JsonConvert.DeserializeObject<ExternalDirectoryList>(jsonResponse);

            handler.Dispose();
            client.Dispose();
            
            return Ok(ext);
        }
    }
}
