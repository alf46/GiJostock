using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data;
using System.Linq;

namespace GiJoStock
{
    public partial class WarehouseFilterForm : MetroForm
    {
        private readonly MetroLink link;

        #region Constructors
        public WarehouseFilterForm(MetroLink link)
        {
            this.InitializeComponent();

            this.dgvWarehouses.AutoGenerateColumns = false;
            var repository = new Repository<Warehouse>();

            var warehouses = repository.GetAll();
            Helpers.SetDataTable(this.dgvWarehouses, warehouses.Where(x => x.Enable).ToList());
            this.link = link;
        }
        #endregion

        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            Warehouse warehouse = null;
            if (this.dgvWarehouses.SelectedRows.Count == 1)
            {
                var view = this.dgvWarehouses.SelectedRows[0].DataBoundItem as DataRowView;
                warehouse = view["Source"] as Warehouse;
            }

            this.link.Tag = warehouse;
            this.Close();
        }
    }
}