using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _repository;

        public UserController(IRepository<User> repository)
        {
            this._repository = repository;
        }

        // GET: api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/user/1
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // PUT: api/user/1
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(int id, User user)
        {
            return await this._repository.Update(id, user);
        }

        // POST: api/user
        [HttpPost]
        public async Task<ActionResult<User>> Add(User user)
        {
            await this._repository.Add(user);
            return this.CreatedAtAction("Get", new { id = user.ID }, user);
        }

        // POST: api/user
        [HttpPost("reset/{id}")]
        public async Task<ActionResult<User>> Reset(int id, ChangePassword ResetPassword)
        {
            return await (this._repository as UserRepository).ResetPassword(id, ResetPassword);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            return await this._repository.Disable(id);
        }

        // POST: api/user
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(Login login)
        {
            return await (this._repository as UserRepository).LoginUser(login);
        }
    }
}