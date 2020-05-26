using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : ControllerBase
    {
        private readonly IRepository<Entry> _repository;

        public EntryController(IRepository<Entry> repository)
        {
            this._repository = repository;
        }

        // GET: api/entry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entry>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/entry/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Entry>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // POST: api/entry
        [HttpPost]
        public async Task<ActionResult<Entry>> Add(Entry entry)
        {
            await this._repository.Add(entry);
            return this.CreatedAtAction("Get", new { id = entry.ID }, entry);
        }
    }
}