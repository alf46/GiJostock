using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class CategoryForm : MetroForm, IForm<Category>, IFormEvents
    {
        #region Attributes
        private readonly Repository<Category> _repository;
        private Category _category;
        #endregion

        #region Events
        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;
        #endregion

        #region Constructors
        public CategoryForm()
        {
            this.InitializeComponent();

            this._repository = new Repository<Category>();
            this.SetEntity(new Category());
        }
        #endregion

        #region Public Methods
        public void SetEntity(Category source)
        {
            this._category = source ?? new Category();
            this.ShowCategory();
        }
        #endregion

        #region Private Methods
        private void ShowCategory()
        {
            this.txtName.Text = this._category.Name;
            this.txtDescription.Text = this._category.Description;
            this.cbxEnable.Checked = this._category.Enable;

            this.picImage.Image = this._category.Image;
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "¿Seguro que desea Guardar este cambio?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this._category.Name = this.txtName.Text;
                    this._category.Description = this.txtDescription.Text;
                    this._category.Enable = this.cbxEnable.Checked;

                    if (this._category.ID == 0)
                    {
                        var added = this._repository.Add(this._category);
                        if (added != null)
                        {
                            OnAdded?.Invoke(added, new EventArgs());
                        }
                    }
                    else
                    {
                        var update = this._repository.Update(this._category);
                        if (update != null)
                        {
                            OnUpdate?.Invoke(update, new EventArgs());
                        }
                    }

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
                    this._category.Image = new Bitmap(dialog.FileName);
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
            this._category.Image = null;
            this.picImage.Image = this._category.Image;
        }
        private void PicImage_DoubleClick(object sender, EventArgs e)
        {
            this.OpenProductImage();
        }
        private void LinkOpenImage_Click(object sender, EventArgs e)
        {
            this.OpenProductImage();
        }
        #endregion
    }
}