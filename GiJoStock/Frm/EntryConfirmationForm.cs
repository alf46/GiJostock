using AFPrinting.Report;
using GiJoStock.Repositories;
using MetroFramework.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class EntryConfirmationForm : MetroForm
    {
        private Entry entry;
        public bool Saved { get; internal set; }

        #region Constructors
        public EntryConfirmationForm(Entry entry)
        {
            this.InitializeComponent();

            this.entry = entry;
            this.entry.UserID = UserRepository.LoggedUser.ID;

            this.lbItems.Text = this.entry.Items.ToString();
            this.lbTotal.Text = string.Format("RD$ {0:#,0.00}", this.entry.EntryItems.Sum(x => (x.PriceIN * x.Stock)));
            this.lbTotal.Text = "$RD " + this.entry.EntryItems.Sum(x => (x.PriceIN * x.Stock));
        }

        #endregion

        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            try
            {
                var repository = new Repository<Entry>();
                this.entry = repository.Add(this.entry);

                this.btnSaveEntry.Enabled = false;

                this.lbMessage.Text = "¡Entrada guardada correctamente!";
                this.lbMessage.ForeColor = Color.LimeGreen;

                this.linkSave.Visible = true;
                this.Saved = true;
            }
            catch (System.Exception ex)
            {
                ex.ShowDialog();
            }
        }

        private void LinkSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = new PrintDocument();
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    ReportManager.RunEntry(this.entry, printDialog1.Document);
                }
            }
            catch (System.Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}