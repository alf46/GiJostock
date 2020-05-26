using AFPrinting.Report;
using GiJoStock.Frm;
using GiJoStock.Repositories;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class MainForm : MetroForm
    {
        #region Attributes
        private readonly BindingSource entrySource;
        private readonly BindingSource invoiceSource;
        #endregion

        #region Constructors
        public MainForm()
        {
            this.InitializeComponent();

            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvSuppliers.AutoGenerateColumns = false;
            this.dgvWarehouses.AutoGenerateColumns = false;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvEntry.AutoGenerateColumns = false;
            this.dgvEntries.AutoGenerateColumns = false;
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoices.AutoGenerateColumns = false;
            this.dgvReport.AutoGenerateColumns = false;

            this.TabControl.SelectedTab = this.pageProduct;

            // Cargar todos.
            this.btnLoadUsers.LoadEntitiesClick<User>(this.dgvUsers);
            this.btnLoadCategories.LoadEntitiesClick<Category>(this.dgvCategories);
            this.btnLoadSuppliers.LoadEntitiesClick<Supplier>(this.dgvSuppliers);
            this.btnLoadWarehouses.LoadEntitiesClick<Warehouse>(this.dgvWarehouses);
            this.btnLoadEntries.LoadEntitiesClick<Entry>(this.dgvEntries);
            this.btnLoadInvoices.LoadEntitiesClick<Invoice>(this.dgvInvoices);

            // Agregar nuevo.
            this.btnAddUser.AddEntityClick<User, UserNewForm>(this.dgvUsers);
            this.btnAddCategory.AddEntityClick<Category, CategoryForm>(this.dgvCategories);
            this.btnAddSupplier.AddEntityClick<Supplier, SupplierForm>(this.dgvSuppliers);
            this.btnAddWarehouse.AddEntityClick<Warehouse, WarehouseForm>(this.dgvWarehouses);
            this.btnAddProduct.AddEntityClick<Product, ProductNewForm>(this.dgvProducts);

            this.productFilter.OnLoaded += this.ProductFilter_OnLoaded;
            //this.productFilter.SetDataGridView(this.dgvProducts);

            // Entrada.
            this.searchProductControl1.OnPush += this.SearchProductControl1_OnPush;

            // Salida.
            this.searchInvoice.OnPush += this.SearchProductControl2_OnPush;

            this.entrySource = new BindingSource();
            this.entrySource.DataSource = typeof(EntryItem);
            this.dgvEntry.DataSource = this.entrySource;

            this.invoiceSource = new BindingSource();
            this.invoiceSource.DataSource = typeof(InvoiceItem);
            this.dgvInvoice.DataSource = this.invoiceSource;

            this.SearchTransfer.OnPush += this.SearchTransfer_OnPush;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    if (UserRepository.LoggedUser == null)
                    {
                        throw new Exception("Usuario inválido");
                    }
                }
                else Environment.Exit(0);

                // Detalle y desabilitar.
                this.dgvUsers.CellContentClick<User, UserUpdateForm>();
                this.dgvCategories.CellContentClick<Category, CategoryForm>();
                this.dgvSuppliers.CellContentClick<Supplier, SupplierForm>();
                this.dgvWarehouses.CellContentClick<Warehouse, WarehouseForm>();
                this.dgvEntries.CellContentClick<Entry, EntryItemForm>();
                this.dgvProducts.CellContentClick<Product, ProductForm>();
                this.dgvInvoices.CellContentClick<Invoice, InvoiceItemForm>();

                this.lbUser.Text = UserRepository.LoggedUser.Username;

                this.SetUserPrivilege();

                this.errorValidator1.ErrorWhen(this.lkWarehouse, x => (x.Tag as Warehouse) == null, "El Almacen destino es requerido!", "Entry");
                this.errorValidator1.ErrorWhen(this.dgvEntry, x => x.Rows.Count <= 0, "No hay productos de entrada", "Entry");

                this.errorValidator1.ErrorWhen(this.linkSupplierInvoice, x => (x.Tag as Supplier) == null, "El Cliente de la factura es requerido!", "Invoice");
                this.errorValidator1.ErrorWhen(this.linkWarehouseInvoice, x => (x.Tag as Warehouse) == null, "El Almacen destino es requerido!", "Invoice");
                this.errorValidator1.ErrorWhen(this.dgvInvoice, x => x.Rows.Count <= 0, "No hay productos de entrada", "Invoice");
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
                Environment.Exit(-1);
            }
        }

        private void SetUserPrivilege()
        {
            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.CreateUser))
            {
                this.btnAddUser.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.CreateProduct))
            {
                this.btnAddProduct.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.CreateEntity))
            {
                this.btnAddCategory.Enabled = false;
                this.btnAddSupplier.Enabled = false;
                this.btnAddWarehouse.Enabled = false;
            }

            // Modulos.
            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.ProductModule))
            {
                this.btnViewProduct.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.EntryModule))
            {
                this.btnViewEntry.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.InvoiceModule))
            {
                this.btnViewInvoice.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.HistoryModule))
            {
                this.btnViewHistory.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.UserModule))
            {
                this.btnViewUser.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.MaintenanceModule))
            {
                this.btnViewMaintenance.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.ReportModule))
            {
                this.btnViewReport.Enabled = false;
            }

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.InventoryModule))
            {
                this.btnViewInventory.Enabled = false;
            }
        }

        private void ProductFilter_OnLoaded(object sender, EventArgs e)
        {
            Helpers.SetDataTable(this.dgvProducts, sender as List<Product>);
        }

        #region Clicks
        private void LbUser_Click(object sender, EventArgs e)
        {
            try
            {
                UserUpdateForm userUpdateForm = new UserUpdateForm();
                userUpdateForm.SetEntity(UserRepository.LoggedUser);
                userUpdateForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        #endregion

        #region Render Pages
        private void BtnViewProduct_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageProduct);
        }
        public void SetPage(params MetroTabPage[] pages)
        {
            try
            {
                // Ocultar todas las demas paginas.
                foreach (MetroTabPage itemPage in this.TabControl.TabPages)
                {
                    this.TabControl.HideTab(itemPage);
                }

                foreach (var page in pages)
                {
                    // Mostar la pagina.
                    this.TabControl.ShowTab(page);

                    this.ChangeView(true);
                }
            }
            catch (Exception)
            {
            }
        }
        private void ChangeView(bool viewTab)
        {
            try
            {
                if (viewTab)
                {
                    this.MainPanel.Visible = false;
                    this.TabControl.Visible = true;
                    this.panelTitle.Visible = true;
                }
                else
                {
                    this.MainPanel.Visible = true;
                    this.TabControl.Visible = false;
                    this.panelTitle.Visible = false;
                }
            }
            catch
            {
            }
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.ChangeView(false);
        }
        private void BtnViewIn_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageEntry);
        }
        private void BtnViewUser_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageUsers);
        }
        #endregion

        private void SearchProductControl1_OnPush(int stock, Product product)
        {
            foreach (EntryItem item in this.entrySource.List)
            {
                if (item.ProductID == product.ID)
                {
                    item.Stock += stock;
                    this.entrySource.ResetBindings(false);
                    return;
                }
            }

            var entryItem = new EntryItem
            {
                ProductID = product.ID,
                Name = product.Name,
                Category = product.Category.Name,
                PriceIN = product.PriceIN,
                AvailableQuantity = product.AvailableQuantity,
                Stock = stock
            };

            this.entrySource.Add(entryItem);
        }
        private void BtnAddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate("Entry"))
                {
                    return;
                }

                Entry entry = new Entry();
                entry.Comment = this.txtEntryComment.Text;
                entry.Reference = this.txtEntryReference.Text;
                entry.WarehouseID = (this.lkWarehouse.Tag as Warehouse).ID;

                entry.EntryItems = new List<EntryItem>();
                foreach (EntryItem item in this.entrySource.List)
                {
                    entry.EntryItems.Add(item);
                }

                EntryConfirmationForm confirmationForm = new EntryConfirmationForm(entry);
                confirmationForm.ShowDialog();
                if (confirmationForm.Saved)
                {
                    this.ClearEntry();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ClearEntry()
        {
            // Limpiar.
            this.searchProductControl1.Clean();
            this.lkWarehouse.Tag = null;
            this.ShowWarehouseEntry();
            this.txtEntryComment.Text = string.Empty;
            this.txtEntryReference.Text = string.Empty;
            this.entrySource.Clear();
        }
        private void DgvEntry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dataGrid = sender as DataGridView;
                string column = dataGrid.Columns[e.ColumnIndex].Name;
                if (string.Equals(column, "col_entry_remove", StringComparison.OrdinalIgnoreCase))
                {
                    if (dataGrid.Rows[e.RowIndex].DataBoundItem is EntryItem entryItem)
                    {
                        this.entrySource.Remove(entryItem);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void LkWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseFilterForm warehouseFilterForm = new WarehouseFilterForm(sender as MetroLink);
                warehouseFilterForm.ShowDialog();
                this.ShowWarehouseEntry();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ShowWarehouseEntry()
        {
            if (this.lkWarehouse.Tag is Warehouse warehouse)
            {
                this.lbWarehouseName.Text = warehouse.Name;
                this.lbWarehousePhone.Text = warehouse.Phone;
                this.lbWarehouseAddress.Text = warehouse.Address;
            }
            else
            {
                this.lbWarehouseName.Text = "---";
                this.lbWarehousePhone.Text = "---";
                this.lbWarehouseAddress.Text = "---";
            }
        }
        private void SearchProductControl2_OnPush(int stock, Product product)
        {
            foreach (InvoiceItem item in this.invoiceSource.List)
            {
                if (item.ProductID == product.ID)
                {
                    item.Stock += stock;
                    this.invoiceSource.ResetBindings(false);
                    return;
                }
            }

            var invoiceItem = new InvoiceItem
            {
                ProductID = product.ID,
                Name = product.Name,
                Category = product.Category.Name,
                PriceOUT = product.PriceOUT,
                AvailableQuantity = product.AvailableQuantity,
                Stock = stock
            };

            this.invoiceSource.Add(invoiceItem);
        }
        private void BtnSaveInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate("Invoice"))
                {
                    return;
                }

                Invoice invoice = new Invoice();
                invoice.Observations = this.txtCommentInvoice.Text;
                invoice.Reference = this.txtRefInvoice.Text;
                invoice.PaymentMethod = this.txtPaymentMethod.Text;

                invoice.WarehouseID = (this.linkWarehouseInvoice.Tag as Warehouse).ID;
                invoice.SupplierID = (this.linkSupplierInvoice.Tag as Supplier).ID;

                invoice.InvoiceItems = new List<InvoiceItem>();
                foreach (InvoiceItem item in this.invoiceSource.List)
                {
                    invoice.InvoiceItems.Add(item);
                }

                var confirmationForm = new InvoiceConfirmationForm(invoice);
                confirmationForm.ShowDialog();
                if (confirmationForm.Saved)
                {
                    // Limpiar.
                    this.linkWarehouseInvoice.Tag = null;
                    this.ShowWarehouseInvoice();

                    this.linkSupplierInvoice.Tag = null;
                    this.ShowCustomerInvoice();

                    this.txtCommentInvoice.Text = string.Empty;
                    this.txtRefInvoice.Text = string.Empty;
                    this.txtPaymentMethod.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void LinkWarehouseInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseFilterForm warehouseFilterForm = new WarehouseFilterForm(sender as MetroLink);
                warehouseFilterForm.ShowDialog();
                this.ShowWarehouseInvoice();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ShowWarehouseInvoice()
        {
            this.searchInvoice.Clean();
            this.invoiceSource.Clear();

            if (this.linkWarehouseInvoice.Tag is Warehouse warehouse)
            {
                this.searchInvoice.Filter.WarehouseID = warehouse.ID;

                this.lbWarehouseNameIN.Text = warehouse.Name;
                this.lbWarehouseAddressIN.Text = warehouse.Phone;
                this.lbWarehousePhoneIN.Text = warehouse.Address;

                this.searchInvoice.Enabled = true;
            }
            else
            {
                this.searchInvoice.Filter.WarehouseID = null;

                this.lbWarehouseNameIN.Text = "---";
                this.lbWarehouseAddressIN.Text = "---";
                this.lbWarehousePhoneIN.Text = "---";

                this.searchInvoice.Enabled = false;
            }
        }
        private void LinkSupplierInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierFilterForm categoryFilter = new SupplierFilterForm(this.linkSupplierInvoice, true);
                categoryFilter.ShowDialog();
                this.ShowCustomerInvoice();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ShowCustomerInvoice()
        {
            if (this.linkSupplierInvoice.Tag is Supplier supplier)
            {
                this.lbCustomerName.Text = supplier.Name;
                this.lbCustomerAddress.Text = supplier.Address;
                this.lbCustomerPhone.Text = supplier.Phone;
                this.lbCustomerRNC.Text = supplier.Document;
            }
            else
            {
                this.lbCustomerName.Text = "---";
                this.lbCustomerAddress.Text = "---";
                this.lbCustomerPhone.Text = "---";
                this.lbCustomerRNC.Text = "---";
            }
        }
        private void BtnPrintEntries_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = new PrintDocument();
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var re = new Repository<Entry>();
                    var inv = re.Get(2);
                    ReportManager.RunEntry(inv, printDialog1.Document);
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }
        private void BorderPanel2_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Crimson, ButtonBorderStyle.Dashed);
        }
        private void LinkWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseFilterForm warehouseFilterForm = new WarehouseFilterForm(sender as MetroLink);
                warehouseFilterForm.ShowDialog();
                this.ShowWarehouseReport();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ShowWarehouseReport()
        {
            if (this.linkWarehouseReport.Tag is Warehouse warehouse)
            {
                this.lbWarehouseNameReport.Text = warehouse.Name;
                this.lbWarehouseAddressReport.Text = warehouse.Address;
                this.lbWarehousePhoneReport.Text = warehouse.Phone;
                this.btnLoadReport.Enabled = true;
            }
            else
            {
                this.lbWarehouseNameReport.Text = "---";
                this.lbWarehouseAddressReport.Text = "---";
                this.lbWarehousePhoneReport.Text = "---";
            }
        }
        private void BtnLoadReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.linkWarehouseReport.Tag is Warehouse warehouse)
                {
                    var rep = new Repository<Product>();
                    var products = rep.GetAll(new Dictionary<string, object> { { "WarehouseID", warehouse.ID } });
                    this.dgvReport.DataSource = products;

                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvReport.DataSource is List<Product> products)
                {
                    var warehouse = this.linkWarehouseReport.Tag as Warehouse;

                    ReportManager.RunPhysicalInventory(products, warehouse);
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void BtnViewMaintenance_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageCategory, this.pageSupplier, this.pageWarehouse);
        }
        private void BtnViewInvoice_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageInvoice);
        }
        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageEntryHistory, this.pageInvoiceHistory);
        }
        private void BtnViewReport_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageReport);
        }
        private void BtnViewInventory_Click(object sender, EventArgs e)
        {
            this.SetPage(this.pageInventory);
        }
        private void BtnTranWareHouseFrom_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseFilterForm warehouseFilterForm = new WarehouseFilterForm(sender as MetroLink);
                warehouseFilterForm.ShowDialog();

                if ((sender as MetroLink).Tag is Warehouse warehouse)
                {
                    this.lbWareFromName.Text = warehouse.Name;
                    this.lbWareFromAddress.Text = warehouse.Address;
                    this.lbWareFromPhone.Text = warehouse.Phone;

                    this.SearchTransfer.Filter.WarehouseID = warehouse.ID;
                    this.SearchTransfer.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void BtnTranWareHouseTo_Click(object sender, EventArgs e)
        {
            try
            {
                WarehouseFilterForm warehouseFilterForm = new WarehouseFilterForm(sender as MetroLink);
                warehouseFilterForm.ShowDialog();

                if ((sender as MetroLink).Tag is Warehouse warehouse)
                {
                    this.lbWareToName.Text = warehouse.Name;
                    this.lbWareToAddress.Text = warehouse.Address;
                    this.lbWareToPhone.Text = warehouse.Phone;
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void SearchTransfer_OnPush(int stock, Product product)
        {
            try
            {
                this.btnTransferProduct.Tag = product;
                this.picImageProductTranfer.Image = product.Image;

                this.lbID.Text = product.ID.ToString();
                this.lnProductName.Text = product.Name;
                this.lnProductCategory.Text = product.Category?.ToString();

                this.lnProductSupplier.Text = product.Supplier?.ToString();

                this.lnProductPriceIN.Text = product.PriceINStr;
                this.lnProductPriceOUT.Text = product.PriceOUTStr;

                this.lbProductAvailableQuantity.Text = product.AvailableQuantity.ToString();

                this.lbTransferStock.Text = stock.ToString();

                if (!string.IsNullOrWhiteSpace(product.Description))
                {
                    this.lbProductDescriptionLabel.Visible = true;
                    this.lbProductDescription.Visible = true;
                    this.lbProductDescription.Text = product.Description;
                }
                else
                {
                    this.lbProductDescriptionLabel.Visible = false;
                    this.lbProductDescription.Visible = false;
                    this.lbProductDescription.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void ClearTranfer()
        {
            try
            {
                this.SearchTransfer.Clean();

                this.btnTransferProduct.Tag = null;
                this.picImageProductTranfer.Image = null;

                this.lbID.Text = "---";
                this.lnProductName.Text = "---";
                this.lnProductCategory.Text = "---";

                this.lnProductSupplier.Text = "---";

                this.lnProductPriceIN.Text = "---";
                this.lnProductPriceOUT.Text = "---";

                this.lbProductAvailableQuantity.Text = "---";

                this.lbTransferStock.Text = "---";


                this.lbProductDescriptionLabel.Visible = false;
                this.lbProductDescription.Visible = false;
                this.lbProductDescription.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void BtnTransferProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnTranWareHouseFrom.Tag is Warehouse from)
                {
                    if (this.btnTranWareHouseTo.Tag is Warehouse to)
                    {
                        if (from.ID == to.ID)
                        {
                            throw new Exception("Los Alamacenes no puede ser los mismos.");
                        }

                        if (this.btnTransferProduct.Tag is Product product)
                        {
                            var stock = int.Parse(this.lbTransferStock.Text);
                            var proRepo = new ProductRepository();
                            var warehouseFrom = product.Warehouses.Select(x => x.Warehouse).FirstOrDefault();

                            var dr = Helpers.ShowDialog("¿Seguro que desea transferir estos productos?",
                                icon: MessageBoxIcon.Question,
                                button: MessageBoxButtons.YesNo);

                            if (dr == DialogResult.Yes)
                            {
                                proRepo.WarehouseTransfer(product.ID, stock, warehouseFrom.ID, to.ID);
                                Helpers.ShowDialog("¡Producto transferido exitosamente!");
                                this.ClearTranfer();
                            }
                        }
                    }
                    else throw new Exception("Debes selecionar el Almacén Destino");
                }
                else throw new Exception("Debes selecionar el Almacén Origen");
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void DgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var dataGrid = sender as DataGridView;
                string column = dataGrid.Columns[e.ColumnIndex].Name;
                if (string.Equals(column, "col_invoice_remove", StringComparison.OrdinalIgnoreCase))
                {
                    if (dataGrid.Rows[e.RowIndex].DataBoundItem is InvoiceItem invoiceItem)
                    {
                        this.invoiceSource.Remove(invoiceItem);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}