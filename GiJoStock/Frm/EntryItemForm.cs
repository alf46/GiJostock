using AFPrinting.Report;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GiJoStock
{
    public partial class EntryItemForm : MetroForm, IForm<Entry>, IFormEvents
    {
        private Entry entry;

        #region Constructors
        public EntryItemForm()
        {
            this.InitializeComponent();

            this.dgvEntryItems.AutoGenerateColumns = false;
        }

        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;

        public void SetEntity(Entry entry)
        {
            this.entry = entry;

            this.lbEntryID.Text = entry.ToString();
            this.lbUser.Text = entry.User?.ToString();

            this.lbWarehouse.Text = entry.Warehouse?.ToString();
            this.lbReference.Text = entry.Reference;
            this.lbItems.Text = entry.Items.ToString();

            this.lbDate.Text = entry.Date.ToString();

            this.entry.SetProductProperties();
            this.dgvEntryItems.DataSource = this.entry.EntryItems;
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