using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataModel.Repositories;
using DataModel;

namespace GiApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _repository;

        public ProductController(IRepository<Product> repository)
        {
            this._repository = repository;
        }

        // GET: api/product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll([FromQuery] ProductFilter filter)
        {
            var productRepository = (ProductRepository)this._repository;
            return await productRepository.GetAll(filter);
        }

        // GET: api/product/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await this._repository.Get(id);
        }

        // PUT: api/product/1
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put(int id, Product product)
        {
            return await this._repository.Update(id, product);
        }

        // POST: api/product
        [HttpPost]
        public async Task<ActionResult<Product>> Add(Product product)
        {
            await this._repository.Add(product);
            return this.CreatedAtAction("Get", new { id = product.ID }, product);
        }

        // GET: api/product
        [HttpGet("transfer/{id}")]
        public async Task<ActionResult<Product>> WarehouseTransfer(int id, [FromQuery]int stock, [FromQuery]int from, [FromQuery]int to)
        {
            var productRepository = (ProductRepository)this._repository;
            return await productRepository.WarehouseTransfer(id, stock, from, to);
        }

        // GET: api/product
        [HttpGet("entry/{id}")]
        public async Task<ActionResult<Product>> WarehouseEntry(int id, [FromQuery]int stock, [FromQuery]int warehouse)
        {
            var productRepository = (ProductRepository)this._repository;
            return await productRepository.WarehouseEntry(id, stock, warehouse);
        }
    }
}