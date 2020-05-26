using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock.Usercontrol
{
    public partial class ProductFilterControl : UserControl
    {
        public event EventHandler<EventArgs> OnLoaded;

        public int? WarehouseID { get; set; }

        public ProductFilterControl()
        {
            this.InitializeComponent();
        }

        public void Clean()
        {
            this.dtProductTo.Checked = true;
            this.dtProductFrom.Checked = true;

            this.dtProductFrom.Value = DateTime.Now.AddDays(-1);
            this.dtProductTo.Value = DateTime.Now;

            this.txtProductID.Text = string.Empty;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var map = new Dictionary<string, object>();
                if (this.WarehouseID != null)
                    map["WarehouseID"] = this.WarehouseID;

                if (!string.IsNullOrWhiteSpace(this.txtProductID.Text))
                    map["ID"] = this.txtProductID.Text;

                if (this.dtProductFrom.Checked)
                    map["From"] = this.dtProductFrom.Value.Date;

                if (this.dtProductTo.Checked)
                    map["To"] = this.dtProductTo.Value.Date;

                var repo = new Repository<Product>();
                var products = repo.GetAll(map);
                this.OnLoaded?.Invoke(products, new EventArgs());
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}