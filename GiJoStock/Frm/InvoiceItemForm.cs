using AFPrinting.Report;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class InvoiceItemForm : MetroForm, IForm<Invoice>, IFormEvents
    {
        private Invoice invoice;

        #region Constructors
        public InvoiceItemForm()
        {
            this.InitializeComponent();

            this.dgvInvoiceItems.AutoGenerateColumns = false;
        }

        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;

        public void SetEntity(Invoice invoice)
        {
            this.invoice = invoice;

            this.lbAmount.Text = invoice.AmountStr;
            this.lbInvoiceID.Text = invoice.ToString();
            this.lbUser.Text = invoice.User?.ToString();

            this.lbWarehouse.Text = invoice.Warehouse?.ToString();
            this.lbReference.Text = invoice.Reference;
            this.lbItems.Text = invoice.Items.ToString();
            this.lbDate.Text = invoice.Date.ToString();

            this.lbCustomerRNC.Text = invoice.Supplier.Document;
            this.lbCustomerName.Text = invoice.Supplier.Name;
            this.lbCustomerAddress.Text = invoice.Supplier.Address;
            this.lbCustomerPhone.Text = invoice.Supplier.Phone;
            this.lbCustomerEmail.Text = invoice.Supplier.Email;

            this.invoice.SetProductProperties();
            this.dgvInvoiceItems.DataSource = this.invoice.InvoiceItems;
        }
        #endregion

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog printDialog1 = new PrintDialog();
                printDialog1.Document = new PrintDocument();
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReportManager.RunInvoice(this.invoice, printDialog1.Document);
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}