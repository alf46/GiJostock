using GiJoStock.Repositories;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class ProductNewForm : MetroForm, IForm<Product>, IFormEvents
    {
        #region Attributes
        private Product _product;
        private readonly Repository<ProductUp> _repository;
        #endregion

        #region Events
        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;
        #endregion

        #region Constructors
        public ProductNewForm()
        {
            this.InitializeComponent();

            this._repository = new Repository<ProductUp>();
            this.SetEntity(null);
        }
        #endregion

        #region Public Methods
        public void SetEntity(Product source)
        {
            this._product = source ?? new Product();
        }
        #endregion

        #region Private Methods
        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                var propUp = new ProductUp();
                propUp.Name = this.txtName.Text;
                propUp.Description = this.txtDescription.Text;
                propUp.QuantityPerUnit = this.txtQuantityPerUnit.Text;
                propUp.Barcode = this.txtBarcode.Text;

                propUp.PriceIN = double.Parse(this.txtPriceIn.Text);
                propUp.PriceOUT = double.Parse(this.txtPriceOut.Text);

                propUp.CategoryID = (this.lkCategory.Tag as Category).ID;
                propUp.SupplierID = (this.lkSupplier.Tag as Supplier).ID;
                propUp.UserID = UserRepository.LoggedUser.ID;

                propUp.Image64 = this._product.Image64;

                string message = "¿Seguro que desea Guardar este cambio?";
                if (Helpers.ShowDialog(message, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this._repository.Add(propUp);
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

            this.errorValidator1.ErrorWhen(this.txtPriceOut, x => string.IsNullOrWhiteSpace(x.Text), "El precio de venta es requerido");
            this.errorValidator1.ErrorWhen(this.txtPriceOut, x => decimal.Parse(this.txtPriceOut.Text) < 0, "El precio de venta es inválido");

            this.errorValidator1.ErrorWhen(this.txtPriceIn, x => string.IsNullOrWhiteSpace(x.Text), "El precio de entrada es requerido");
            this.errorValidator1.ErrorWhen(this.txtPriceIn, x => decimal.Parse(this.txtPriceIn.Text) < 0, "El precio de entrada es inválido");

            this.errorValidator1.ErrorWhen(this.lkCategory, x => (x.Tag as Category) == null, "La categoria es requerida");
            this.errorValidator1.ErrorWhen(this.lkSupplier, x => (x.Tag as Supplier) == null, "El suplidor es requerido");
        }
        #endregion
    }
}