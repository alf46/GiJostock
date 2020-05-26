using DataModel.StockDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task Add(Product source)
        {
            this._context.Entry(source).State = EntityState.Added;
            return this._context.SaveChangesAsync();
        }

        public Task<Product> Disable(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            return this._context.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .Include(x => x.ProductWarehouses).ThenInclude(x => x.Warehouse)
                .FirstOrDefaultAsync(x => x.Enable && x.ID == id);
        }

        public Task<List<Product>> GetAll()
        {
            return this._context.Products.Where(x => x.Enable)
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .Include(x => x.ProductWarehouses).ThenInclude(x => x.Warehouse)
                .ToListAsync();
        }

        public async Task<List<Product>> GetAll(ProductFilter filter)
        {
            var query = this._context.Products.Where(x => x.Enable);

            if (filter.ID != null)
                query = query.Where(x => x.ID == filter.ID);

            if (filter.WarehouseID != null)
            {
                query = query.Where(x => x.ProductWarehouses.Where(x => x.WarehouseID == filter.WarehouseID && x.Warehouse.Enable && x.Stock > 0).Count() > 0);
            }

            if (filter.From != null)
                query = query.Where(x => x.CreateDate.Date >= filter.From);

            if (filter.To != null)
                query = query.Where(x => x.CreateDate.Date <= filter.To);

            var products = await query.Include(x => x.Category)
                .Include(x => x.Supplier)
                .Include(x => x.ProductWarehouses).ThenInclude(x => x.Warehouse)
                .ToListAsync();

            // Remover las entradas de los productos en los demas almacenes cuando se filtra por almacen.
            if (filter.WarehouseID != null)
            {
                foreach (var product in products)
                {
                    product.ProductWarehouses.RemoveAll(y => y.Warehouse.ID != filter.WarehouseID);
                }
            }

            return products;
        }

        public async Task<Product> WarehouseTransfer(int id, int stock, int from, int to)
        {
            if (stock <= 0)
                throw new ArgumentNullException("Invalid Stock.");

            if (from == to)
                throw new ArgumentNullException("Same Warehouse.");

            // Validar el almacen origen.
            await this.ValidationWarehouse(from);

            // Validar el almacen destino.
            await this.ValidationWarehouse(to);

            var warehouseOrigin = await this.GetProductWarehouse(id, from);
            if (warehouseOrigin == null || warehouseOrigin.Stock < stock)
                throw new ArgumentNullException("Origin Warehouse Inferior Stock.");

            // Obtener el almacen destino.
            var warehouseDestination = await this.GetProductWarehouse(id, to);

            // Si la relación no existe, se crea.
            if (warehouseDestination == null)
            {
                warehouseDestination = new ProductWarehouse
                {
                    ProductID = id,
                    WarehouseID = to
                };

                this._context.Entry(warehouseDestination).State = EntityState.Added;
            }

            // Restar el stock al origen y sumar al destino.
            warehouseOrigin.Stock -= stock;
            warehouseDestination.Stock += stock;

            await this._context.SaveChangesAsync();
            return await this.Get(id);
        }

        public async Task<Product> WarehouseEntry(int id, int stock, int warehouse)
        {
            if (stock <= 0)
            {
                throw new ArgumentNullException("Invalid Stock.");
            }

            // Validar el estado del producto.
            await this.ValidationProduct(id);

            // Validar si el almacen existe.
            await this.ValidationWarehouse(warehouse);

            // Obtener la relación entre el producto y el almacen.
            var warehouseDb = await this.GetProductWarehouse(id, warehouse);

            // Si la relación no existe, se crea.
            if (warehouseDb == null)
            {
                warehouseDb = new ProductWarehouse
                {
                    ProductID = id,
                    WarehouseID = warehouse
                };

                this._context.Entry(warehouseDb).State = EntityState.Added;
            }

            // Restar el stock al origen y sumar al destino.
            warehouseDb.Stock += stock;

            await this._context.SaveChangesAsync();
            return await this.Get(id);
        }

        private async Task ValidationProduct(int id)
        {
            var product = await this._context.Products.FirstOrDefaultAsync(x => x.ID == id && x.Enable);
            if (product == null)
            {
                throw new InvalidOperationException($"The Product '{id}' Not Found Or Disable.");
            }
        }

        private async Task ValidationWarehouse(int warehouse)
        {
            // Obtener el almacen origen.
            if (await this._context.Warehouses.FindAsync(warehouse) == null)
            {
                throw new ArgumentNullException($"The Warehouse '{warehouse}' Not Found.");
            }
        }

        private async Task<ProductWarehouse> GetProductWarehouse(int id, int warehouse)
        {
            return await this._context.ProductWarehouses.FirstOrDefaultAsync(x => x.WarehouseID == warehouse && x.ProductID == id);
        }

        public async Task<Product> Update(int id, Product source)
        {
            var productDb = await this._context.Products.FindAsync(id);
            if (productDb == null)
            {
                throw new ArgumentNullException($"The Product '{id}' Not Found.");
            }

            productDb.Name = source.Name;
            productDb.Description = source.Description;
            productDb.QuantityPerUnit = source.QuantityPerUnit;
            productDb.Barcode = source.Barcode;

            productDb.PriceIN = source.PriceIN;
            productDb.PriceOUT = source.PriceOUT;

            productDb.Image64 = source.Image64;
            productDb.CategoryID = source.CategoryID;
            productDb.SupplierID = source.SupplierID;

            // Guardar los cambios en la base de datos.
            await this._context.SaveChangesAsync();

            return productDb;
        }

    }
}