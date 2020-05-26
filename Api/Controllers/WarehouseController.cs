using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IRepository<Warehouse> _repository;

        public WarehouseController(IRepository<Warehouse> repository)
        {
            this._repository = repository;
        }

        // GET: api/warehouse
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Warehouse>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/warehouse/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Warehouse>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // PUT: api/warehouse/1
        [HttpPut("{id}")]
        public async Task<ActionResult<Warehouse>> Put(int id, Warehouse warehouse)
        {
            return await this._repository.Update(id, warehouse);
        }

        // POST: api/warehouse
        [HttpPost]
        public async Task<ActionResult<Warehouse>> Add(Warehouse warehouse)
        {
            await this._repository.Add(warehouse);
            return this.CreatedAtAction("Get", new { id = warehouse.ID }, warehouse);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Warehouse>> Delete(int id)
        {
            return await this._repository.Disable(id);
        }
    }
}