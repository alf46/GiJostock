using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock
{
    public delegate void PustHandler(int stock, Product product);

    public partial class SearchProductControl : UserControl
    {
        private Product _product;

        public event PustHandler OnPush;

        #region Constructors
        public SearchProductControl()
        {
            this.InitializeComponent();

            this.txtInStock.OnlyNumber();
            this.txtInStock.HasEnterKey(this.TxtInStock_ButtonClick);

            this.Filter.OnLoaded += this.ProductFilterControl1_OnLoaded;
        }

        public void Clean()
        {
            this.Filter.Clean();
            this.pPagination.Controls.Clear();
            this.CleanControls();
        }

        private void ProductFilterControl1_OnLoaded(object sender, EventArgs e)
        {
            try
            {
                this.pPagination.Controls.Clear();

                int x = 0;
                int index = 1;
                var products = sender as List<Product>;
                foreach (Product product in products)
                {
                    bool firstSelect = index == 1;
                    string textLink = (index++).ToString();
                    this.AddLinkPagination(product, x, textLink, firstSelect);
                    x += 27;
                }

                this.ShowProduct(products.FirstOrDefault());
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        #endregion

        #region Private Methods
        private void CleanControls()
        {
            this.lkID.Text = "---";
            this.lbName.Text = "---";
            this.lbCategory.Text = "---";
            this.lbProductStock.Text = "---";
            this.lbSupplier.Text = "---";
            this.lbPrice.Text = "---";
            this.pictureBox1.Image = null;
        }

        private void ShowProduct(Product product)
        {
            if (product != null)
            {
                this.lkID.Tag = product;

                this.lkID.Text = product.ID.ToString();

                this.lbName.Text = product.Name;
                this.lbCategory.Text = product.Category?.ToString();
                this.lbProductStock.Text = product.AvailableQuantity.ToString();
                this.lbSupplier.Text = product.Supplier?.ToString();
                this.lbPrice.Text = product.PriceOUT.ToString();
                this.pictureBox1.Image = product.Image;

                this._product = product;
            }
            else this.CleanControls();
        }

        private void PaginationClick(object sender, EventArgs e)
        {
            foreach (MetroLink item in this.pPagination.Controls)
            {
                item.BackColor = Color.LightGray;
                item.ForeColor = Color.Black;
                item.UseCustomForeColor = false;
            }

            MetroLink metroLink = sender as MetroLink;
            metroLink.UseCustomForeColor = true;
            metroLink.BackColor = Color.DarkViolet;
            metroLink.ForeColor = Color.White;

            // Mostrar los datos del productos.
            this.ShowProduct(metroLink.Tag as Product);
        }

        private void AddLinkPagination(Product product, int x, string name, bool select)
        {
            MetroLink metroLink = new MetroLink();
            metroLink.Location = new Point(x, 0);
            metroLink.Size = new Size(25, 14);
            metroLink.TabIndex = 35;
            metroLink.Text = name;
            metroLink.TextAlign = ContentAlignment.TopCenter;
            metroLink.Click += this.PaginationClick;
            metroLink.UseCustomBackColor = true;
            metroLink.BackColor = Color.LightGray;
            metroLink.UseCustomForeColor = true;
            metroLink.Tag = product;
            this.pPagination.Controls.Add(metroLink);

            if (select)
            {
                this.PaginationClick(metroLink, null);
            }
        }
        #endregion

        private void TxtInStock_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (this._product == null)
                {
                    return;
                }

                if (int.TryParse(this.txtInStock.Text, out int inStock))
                {
                    // Validar cantidad
                    if (inStock <= 0)
                    {
                        throw new Exception("La cantidad debe ser mayor a cero.");
                    }

                    // Validar cantidad disponible.
                    if (this.Filter.WarehouseID != null && inStock > this._product.AvailableQuantity)
                    {
                        throw new Exception("La cantidad no puede ser mayor a la cantidad disponible del producto");
                    }

                    this.txtInStock.Clear();
                    OnPush?.Invoke(inStock, this._product);
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog(MessageBoxIcon.Warning);
            }
        }

        private void DgvEntry_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            if ((anError.Context & DataGridViewDataErrorContexts.Parsing) == DataGridViewDataErrorContexts.Parsing)
            {
                Helpers.ShowDialog("Valor de entrada incorrecto", icon: MessageBoxIcon.Warning);
            }
            else anError.Exception.ShowDialog();
        }
        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void LkID_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Control control && control.Tag is Product product)
                {
                    var productForm = new ProductForm();
                    productForm.SetEntity(product);
                    productForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}