using MetroFramework.Forms;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class OfficeForm : MetroForm
    {
        private Office _office;

        public OfficeForm(Office office = null)
        {
            this.InitializeComponent();

            if (office != null)
            {
                //this._office = (Office)office.Clone();
                this.bindingSource.DataSource = _office;
            }
            else this.bindingSource.DataSource = new Office();
        }

        private async void BtnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!this.validator1.Validate())
                    return;

                Office office = this.bindingSource.DataSource as Office;

                string message = this._office == null ? "¿Seguro que desea Agregar esta Oficina?" :
                                                "¿Seguro que desea Editar esta Oficina?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }

                this.SpAdding.Start();

                //if (this._office == null)
                //{
                //    await DataAccess.AddOffice(office);
                //}
                //else await DataAccess.UpdateOffice(this._office.Id, office);

                this.SpAdding.Stop();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                this.SpAdding.Stop();
                ex.ShowDialog();
            }
        }

        private void OfficeForm_Load(object sender, System.EventArgs e)
        {
            this.validator1.AddValidation(this.txtName, x => string.IsNullOrWhiteSpace(x.Text),
               "El nombre de la oficina es requerido");

            this.validator1.AddValidation(this.txtDeparment, x => string.IsNullOrWhiteSpace(x.Text),
                "El departamento de la oficina es requerido");

            this.validator1.AddValidation(this.txtManager, x => string.IsNullOrWhiteSpace(x.Text),
                "El administrador de la oficina es requerido");

            this.validator1.AddValidation(this.txtEmployees, x => int.Parse(x.Text) <= 0,
                "Cantidad de empleados inválida");
        }
    }
}