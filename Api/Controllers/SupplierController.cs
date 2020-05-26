using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly IRepository<Supplier> _repository;

        public SupplierController(IRepository<Supplier> repository)
        {
            this._repository = repository;
        }

        // GET: api/supplier
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/supplier/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // PUT: api/supplier/1
        [HttpPut("{id}")]
        public async Task<ActionResult<Supplier>> Put(int id, Supplier supplier)
        {
            return await this._repository.Update(id, supplier);
        }

        // POST: api/supplier
        [HttpPost]
        public async Task<ActionResult<Supplier>> Add(Supplier supplier)
        {
            await this._repository.Add(supplier);
            return this.CreatedAtAction("Get", new { id = supplier.ID }, supplier);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Supplier>> Delete(int id)
        {
            return await this._repository.Disable(id);
        }
    }
}