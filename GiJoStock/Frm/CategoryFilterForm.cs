using MetroFramework.Controls;
using MetroFramework.Forms;
using System.Data;
using System.Linq;

namespace GiJoStock
{
    public partial class CategoryFilterForm : MetroForm
    {
        private readonly MetroLink link;

        #region Constructors
        public CategoryFilterForm(MetroLink link)
        {
            this.InitializeComponent();

            this.dgvCategories.AutoGenerateColumns = false;
            var repository = new Repository<Category>();

            var categories = repository.GetAll();
            Helpers.SetDataTable(this.dgvCategories, categories.Where(x => x.Enable).ToList());
            this.link = link;
        }
        #endregion

        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            Category category = null;
            if (this.dgvCategories.SelectedRows.Count == 1)
            {
                var view = this.dgvCategories.SelectedRows[0].DataBoundItem as DataRowView;
                category = view["Source"] as Category;
            }

            this.link.Tag = category;
            this.link.Text = category?.Name ?? "---";
            this.Close();
        }
    }
}