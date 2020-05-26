using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel;
using DataModel.Repositories;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _repository;

        public CategoryController(IRepository<Category> repository)
        {
            this._repository = repository;
        }

        // GET: api/categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/categories/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // PUT: api/Categories/1
        [HttpPut("{id}")]
        public async Task<ActionResult<Category>> Put(int id, Category category)
        {
            return await this._repository.Update(id, category);
        }

        // POST: api/categories
        [HttpPost]
        public async Task<ActionResult<Category>> Add(Category category)
        {
            await this._repository.Add(category);
            return this.CreatedAtAction("Get", new { id = category.ID }, category);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> Delete(int id)
        {
            return await this._repository.Disable(id);
        }
    }
}