using AFPrinting.Report;
using GiJoStock.Repositories;
using MetroFramework.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class InvoiceConfirmationForm : MetroForm
    {
        private Invoice invoice;

        public bool Saved { get; set; }

        #region Constructors
        public InvoiceConfirmationForm(Invoice invoice)
        {
            this.InitializeComponent();

            this.invoice = invoice;
            this.invoice.UserID = UserRepository.LoggedUser.ID;

            this.lbItems.Text = this.invoice.Items.ToString();
            this.lbTotal.Text = string.Format("RD$ {0:#,0.00}", this.invoice.InvoiceItems.Sum(x => (x.PriceOUT * x.Stock)));
        }
        #endregion

        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            try
            {
                var repository = new Repository<Invoice>();
                this.invoice = repository.Add(this.invoice);

                this.btnSaveEntry.Enabled = false;

                this.lbMessage.Text = "¡Factura guardada correctamente!";
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
                    ReportManager.RunInvoice(this.invoice, printDialog1.Document);
                }
            }
            catch (System.Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}