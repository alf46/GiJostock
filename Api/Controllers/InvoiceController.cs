using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IRepository<Invoice> _repository;

        public InvoiceController(IRepository<Invoice> repository)
        {
            this._repository = repository;
        }

        // GET: api/invoice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetAll()
        {
            return await this._repository.GetAll();
        }

        // GET: api/invoice/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // POST: api/invoice
        [HttpPost]
        public async Task<ActionResult<Invoice>> Add(Invoice invoice)
        {
            await this._repository.Add(invoice);
            var inv = await this._repository.Get(invoice.ID);
            return this.CreatedAtAction("Get", new { id = invoice.ID }, inv);
        }
    }
}