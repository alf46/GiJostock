using MetroFramework.Forms;
using Ofimatic.Validators;
using System;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class SupplierForm : MetroForm, IForm<Supplier>, IFormEvents
    {
        #region Attributes
        private readonly Repository<Supplier> _repository;
        private Supplier _supplier;
        #endregion

        #region Events
        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;
        #endregion

        #region Constructors
        public SupplierForm()
        {
            this.InitializeComponent();
            this._repository = new Repository<Supplier>();
            this.SetEntity(new Supplier());
        }
        #endregion

        #region Public Methods
        public void SetEntity(Supplier source)
        {
            this._supplier = source;

            this.txtName.Text = this._supplier.Name;
            this.txtPhone.Text = this._supplier.Phone;
            this.txtEmail.Text = this._supplier.Email;

            this.txtAddress.Text = this._supplier.Address;
            this.txtDocument.Text = this._supplier.Document;

            this.cbkEnable.Checked = this._supplier.Enable;
        }
        #endregion

        #region Public Methods
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                this._supplier.Name = this.txtName.Text;
                this._supplier.Phone = this.txtPhone.Text;
                this._supplier.Email = this.txtEmail.Text;
                this._supplier.Address = this.txtAddress.Text;
                this._supplier.Document = this.txtDocument.Text;

                this._supplier.Enable = this.cbkEnable.Checked;

                string message = "¿Seguro que desea guardar este Cambio?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (this._supplier.ID == 0)
                    {
                        var added = this._repository.Add(this._supplier);
                        if (added != null)
                        {
                            OnAdded?.Invoke(added, new EventArgs());
                        }
                    }
                    else
                    {
                        var update = this._repository.Update(this._supplier);
                        if (update != null)
                        {
                            OnUpdate?.Invoke(update, new EventArgs());
                        }
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            this.errorValidator1.ErrorWhen(this.txtName, x => string.IsNullOrWhiteSpace(x.Text), "El nombre del suplidor  es requerido");
            this.errorValidator1.ErrorWhen(this.txtPhone, x => string.IsNullOrWhiteSpace(x.Text), "El teléfono del suplidor es requerido");
            this.errorValidator1.ErrorWhen(this.txtAddress, x => string.IsNullOrWhiteSpace(x.Text), "La dirección del suplidor es requerida");
            this.errorValidator1.ErrorWhen(this.txtDocument, x => string.IsNullOrWhiteSpace(x.Text), "El RNC/Cédula del supplidor es requerido");

            this.errorValidator1.ErrorWhen(this.txtEmail, x => !string.IsNullOrWhiteSpace(x.Text) && !Validators.EmailValidator(x.Text), "El correo electrónicos es inválido");
        }
        #endregion
    }
}