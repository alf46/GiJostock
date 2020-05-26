using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class WarehouseForm : MetroForm, IForm<Warehouse>, IFormEvents
    {
        #region Attributes
        private readonly Repository<Warehouse> _repository;
        private Warehouse _warehouse;
        #endregion

        #region Events
        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;
        #endregion

        #region Constructors
        public WarehouseForm()
        {
            this.InitializeComponent();
            this._repository = new Repository<Warehouse>();
            this.SetEntity(new Warehouse());
        }
        #endregion

        #region Public Methods
        public void SetEntity(Warehouse source)
        {
            this._warehouse = source;

            this.txtName.Text = this._warehouse.Name;
            this.txtPhone.Text = this._warehouse.Phone;
            this.txtAddress.Text = this._warehouse.Address;

            this.cbkEnable.Checked = this._warehouse.Enable;
            this.cbkDefault.Checked = this._warehouse.Default;
        }
        #endregion

        #region Private Methods
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                this._warehouse.Name = this.txtName.Text;
                this._warehouse.Phone = this.txtPhone.Text;
                this._warehouse.Address = this.txtAddress.Text;

                this._warehouse.Enable = this.cbkEnable.Checked;
                this._warehouse.Default = this.cbkDefault.Checked;

                string message = "¿Seguro que desea guardar este Cambio?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (this._warehouse.ID == 0)
                    {
                        var added = this._repository.Add(this._warehouse);
                        if (added != null)
                        {
                            OnAdded?.Invoke(added, new EventArgs());
                        }
                    }
                    else
                    {
                        var update = this._repository.Update(this._warehouse);
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
            this.errorValidator1.ErrorWhen(this.txtName, x => string.IsNullOrWhiteSpace(x.Text), "El nombre del almacén  es requerido");
            this.errorValidator1.ErrorWhen(this.txtPhone, x => string.IsNullOrWhiteSpace(x.Text), "El teléfono del almacén es requerido");
            this.errorValidator1.ErrorWhen(this.txtAddress, x => string.IsNullOrWhiteSpace(x.Text), "La dirección del almacén es requerida");
        }
        #endregion
    }
}