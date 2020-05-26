using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class ProductForm : MetroForm, IForm<Product>, IFormEvents
    {
        private Product _product;

        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;

        #region Constructors
        public ProductForm()
        {
            this.InitializeComponent();
        }
        #endregion

        public void SetEntity(Product source)
        {
            this._product = source ?? new Product();
            this.ShowCategory();
        }

        private ProductUp GetProductUpdate()
        {
            return new ProductUp
            {
                ID = _product.ID,

                Name = this.txtName.Text,
                Description = this.txtDescription.Text,
                QuantityPerUnit = this.txtQuantityPerUnit.Text,
                Barcode = this.txtBarcode.Text,

                PriceIN = double.Parse(this.txtPriceIn.Text),
                PriceOUT = double.Parse(this.txtPriceOut.Text),

                CategoryID = (this.lkCategory.Tag as Category).ID,
                SupplierID = (this.lkSupplier.Tag as Supplier).ID,

                Image64 = this._product.Image64,
            };
        }

        private void ShowCategory()
        {
            this.lbID.Text = this._product.ID.ToString();
            this.lbCreateDate.Text = this._product.CreateDate.ToString();
            this.lbAvailableQuantity.Text = this._product.AvailableQuantity.ToString();

            this.txtName.Text = this._product.Name;
            this.txtDescription.Text = this._product.Description;
            this.txtQuantityPerUnit.Text = this._product.QuantityPerUnit;
            this.txtBarcode.Text = this._product.Barcode;

            this.txtPriceIn.Text = this._product.PriceIN.ToString();
            this.txtPriceOut.Text = this._product.PriceOUT.ToString();

            this.lkCategory.Tag = this._product.Category;
            this.lkCategory.Text = this._product.Category.Name;

            this.lkSupplier.Tag = this._product.Supplier;
            this.lkSupplier.Text = this._product.Supplier.Name;

            this.picImage.Image = this._product.Image;

            this.warehouseControl1.Update(this._product.Warehouses);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                var propUp = this.GetProductUpdate();

                string message = "¿Seguro que desea Guardar este cambio?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var repo = new Repository<ProductUp>();
                    repo.Update(propUp);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }

        private void OpenProductImage()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this._product.Image = new Bitmap(dialog.FileName);
                    this.picImage.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }

        private void BtnRemoveImg_Click(object sender, EventArgs e)
        {
            this._product.Image = null;
            this.picImage.Image = this._product.Image;
        }

        private void PicImage_DoubleClick(object sender, EventArgs e)
        {
            this.OpenProductImage();
        }

        private void LinkOpenImage_Click(object sender, EventArgs e)
        {
            this.OpenProductImage();
        }

        private void LkCategory_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryFilterForm categoryFilter = new CategoryFilterForm(this.lkCategory);
                categoryFilter.ShowDialog();
            }
            catch
            {
            }
        }

        private void LkSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierFilterForm categoryFilter = new SupplierFilterForm(this.lkSupplier);
                categoryFilter.ShowDialog();
            }
            catch
            {
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            this.errorValidator1.ErrorWhen(this.txtName, x => string.IsNullOrWhiteSpace(x.Text), "El nombre del producto es requerido");
            this.errorValidator1.ErrorWhen(this.txtPriceOut, x => string.IsNullOrWhiteSpace(x.Text), "El precio del producto es requerido");
            this.errorValidator1.ErrorWhen(this.txtPriceOut, x => decimal.Parse(this.txtPriceOut.Text) < 0, "El precio del producto es inválido");

            this.errorValidator1.ErrorWhen(this.lkCategory, x => (x.Tag as Category) == null, "La categoria es requerida");
            this.errorValidator1.ErrorWhen(this.lkSupplier, x => (x.Tag as Supplier) == null, "El suplidor es requerido");
        }
    }
}