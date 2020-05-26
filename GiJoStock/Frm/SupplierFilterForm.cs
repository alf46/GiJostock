using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data;
using System.Linq;

namespace GiJoStock
{
    public partial class SupplierFilterForm : MetroForm
    {
        private readonly MetroLink link;

        #region Constructors
        public SupplierFilterForm(MetroLink link, bool customer = false)
        {
            this.InitializeComponent();

            if (customer)
            {
                this.Text = "Búsqueda de Clientes";
            }

            this.dgvSupplier.AutoGenerateColumns = false;
            var repository = new Repository<Supplier>();

            var suppliers = repository.GetAll();
            Helpers.SetDataTable(this.dgvSupplier, suppliers.Where(x => x.Enable).ToList());
            this.link = link;
        }
        #endregion

        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            Supplier supplier = null;
            if (this.dgvSupplier.SelectedRows.Count == 1)
            {
                var view = this.dgvSupplier.SelectedRows[0].DataBoundItem as DataRowView;
                supplier = view["Source"] as Supplier;
            }

            this.link.Tag = supplier;
            this.link.Text = supplier?.Name ?? "---";
            this.Close();
        }
    }
}