using DataModel.Repositories;
using DataModel.StockDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel
{
    public class InvoiceRepository : IRepository<Invoice>
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task Add(Invoice source)
        {
            // Validar el almacen.
            var warehouse = await this.ValidationWarehouse(source.WarehouseID);

            // Validar la cantidad de Items.
            if (source.InvoiceItems == null || source.InvoiceItems.Count <= 0)
            {
                throw new InvalidOperationException("Cantidad de Items invalida.");
            }

            source.Amount = 0M;

            // Procesar los items.
            foreach (var item in source.InvoiceItems)
            {
                // validar el stock.
                if (item.Stock <= 0)
                {
                    throw new InvalidOperationException("El Stock debe ser mayor a cero.");
                }

                // Guardar el item.
                await this.ValidationProduct(item.ProductID);
                this._context.Entry(item).State = EntityState.Added;

                // Guardar la entrada por almacen.
                var prodWare = await this.GetProductWarehouse(item.ProductID, warehouse.ID);
                if (prodWare == null)
                {
                    throw new InvalidOperationException("El Stock del producto es invalido en el almacen espesificado.");
                }

                // validar el stock.
                if (item.Stock > prodWare.Stock)
                {
                    throw new InvalidOperationException("La cantidad disponible del producto es inferior a la cantidad de salida");
                }

                source.Amount += (prodWare.Product.PriceOUT * item.Stock);
                prodWare.Stock -= item.Stock;
            }

            this._context.Entry(source).State = EntityState.Added;
            await this._context.SaveChangesAsync();
        }

        public Task<Invoice> Disable(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Invoice> Get(int id)
        {
            return this._context.Invoices.Include(x => x.Warehouse)
                .Include(x => x.InvoiceItems).ThenInclude(x => x.Product)
                .Include(x => x.Supplier)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public Task<List<Invoice>> GetAll()
        {
            return this._context.Invoices.Include(x => x.Warehouse)
                .Include(x => x.InvoiceItems).ThenInclude(x => x.Product)
                .Include(x => x.Supplier)
                .Include(x => x.User)
                .ToListAsync();
        }

        public Task<Invoice> Update(int id, Invoice source)
        {
            throw new System.NotImplementedException();
        }

        private async Task<Warehouse> ValidationWarehouse(int warehouse)
        {
            // Obtener el almacen origen.
            var ware = await this._context.Warehouses.FindAsync(warehouse);
            if (ware == null || !ware.Enable)
            {
                throw new ArgumentNullException($"The Warehouse '{warehouse}' is invalid.");
            }
            else return ware;
        }
        private async Task ValidationProduct(int id)
        {
            var product = await this._context.Products.FirstOrDefaultAsync(x => x.ID == id && x.Enable);
            if (product == null)
            {
                throw new InvalidOperationException($"The Product '{id}' Not Found Or Disable.");
            }
        }
        private async Task<ProductWarehouse> GetProductWarehouse(int id, int warehouse)
        {
            return await this._context.ProductWarehouses.FirstOrDefaultAsync(x => x.WarehouseID == warehouse && x.ProductID == id);
        }
    }
}