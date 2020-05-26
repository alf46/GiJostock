using DataModel.Repositories;
using DataModel.StockDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel
{
    public class EntryRepository : IRepository<Entry>
    {
        #region Attributes
        private readonly ApplicationDbContext _context;
        #endregion

        #region Constructors
        public EntryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public Methods
        public async Task Add(Entry source)
        {
            // Validar el almacen.
            var warehouse = await this.ValidationWarehouse(source.WarehouseID);

            // Validar la cantidad de Items.
            if (source.EntryItems.Count <= 0)
            {
                throw new GiJoException("Cantidad de Items invalida.");
            }

            // Procesar los items.
            foreach (var item in source.EntryItems)
            {
                // validar el stock.
                if (item.Stock <= 0)
                {
                    throw new GiJoException("El Stock debe ser mayor a cero.");
                }

                // Guardar el item.
                await this.ValidationProduct(item.ProductID);
                this._context.Entry(item).State = EntityState.Added;

                // Guardar la entrada por almacen.
                var prodWare = await this.GetProductWarehouse(item.ProductID, warehouse.ID);
                if (prodWare == null)
                {
                    prodWare = new ProductWarehouse { ProductID = item.ProductID, WarehouseID = warehouse.ID };
                    this._context.Entry(prodWare).State = EntityState.Added;
                }

                prodWare.Stock += item.Stock;
            }

            this._context.Entry(source).State = EntityState.Added;
            await this._context.SaveChangesAsync();
        }
        public Task<Entry> Disable(int id)
        {
            throw new GiJoException("Método no implementado.");
        }
        public Task<Entry> Get(int id)
        {
            return this._context.Entries.Include(x => x.Warehouse)
                .Include(x => x.EntryItems).ThenInclude(x => x.Product)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.ID == id);
        }
        public Task<List<Entry>> GetAll()
        {
            return this._context.Entries.Include(x => x.Warehouse)
                .Include(x => x.EntryItems).ThenInclude(x => x.Product)
                .Include(x => x.User)
                .ToListAsync();
        }
        public Task<Entry> Update(int id, Entry source)
        {
            throw new GiJoException("Método no implementado.");
        }
        #endregion

        #region Private Methods
        private async Task<Warehouse> ValidationWarehouse(int warehouse)
        {
            // Obtener el almacen origen.
            var ware = await this._context.Warehouses.FindAsync(warehouse);
            if (ware == null || !ware.Enable)
            {
                throw new GiJoException($"El Almacén '{warehouse}' es inválido.");
            }
            else return ware;
        }
        private async Task ValidationProduct(int id)
        {
            var product = await this._context.Products.FirstOrDefaultAsync(x => x.ID == id && x.Enable);
            if (product == null)
            {
                throw new GiJoException($"El Producto '{id}' no existe o esta deshabilitado.");
            }
        }
        private async Task<ProductWarehouse> GetProductWarehouse(int id, int warehouse)
        {
            return await this._context.ProductWarehouses.FirstOrDefaultAsync(x => x.WarehouseID == warehouse && x.ProductID == id);
        }
        #endregion
    }
}