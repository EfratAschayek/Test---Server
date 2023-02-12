using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserModel>> Get()
        {
            return await _service.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserModel> Get(string id)
        {
            return await _service.GetByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserModel?> Post([FromBody] UserModel user)
        {
            if (await _service.GetByIdAsync(user.IdNumber) != null)
            {
                return null;
            }
            return await _service.AddAsync(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
