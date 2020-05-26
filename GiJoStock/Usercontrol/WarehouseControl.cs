using GiJoStock.Frm;
using MetroFramework;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GiJoStock.Usercontrol
{
    public partial class WarehouseControl : UserControl
    {
        private int _index = 7;
        private readonly int _margin = 20;
        private bool _has = true;

        public WarehouseControl()
        {
            this.InitializeComponent();
        }

        public void Update(List<ProductWarehouse> warehouses)
        {
            if (warehouses == null)
            {
                return;
            }

            foreach (var item in warehouses)
            {
                this.AddControls(item);
            }

            if (warehouses.Count <= 0)
            {
                this.warehousePanel.Visible = false;
                this._has = false;
                this.Invalidate();
            }
        }

        #region Private Methods
        private void AddControls(ProductWarehouse productWarehouse)
        {
            var metroLabel1 = new MetroLabel();
            metroLabel1.AutoSize = true;
            metroLabel1.FontWeight = MetroLabelWeight.Bold;
            metroLabel1.Location = new Point(15, this._index);
            metroLabel1.Size = new Size(33, 19);
            metroLabel1.Text = productWarehouse.Stock.ToString();
            metroLabel1.UseCustomForeColor = true;
            metroLabel1.ForeColor = Color.MediumSeaGreen;

            if (productWarehouse.Stock <= 0)
            {
                metroLabel1.ForeColor = Color.Crimson;
            }

            if (!productWarehouse.Warehouse.Enable)
            {
                metroLabel1.ForeColor = Color.OrangeRed;
            }

            this.warehousePanel.Controls.Add(metroLabel1);

            var link = new MetroLink();
            link.Location = new Point(50, this._index);
            link.Size = new Size(75, 23);
            link.TabIndex = 2;
            link.AutoSize = true;
            link.Text = productWarehouse.Warehouse.Name;
            link.TextAlign = ContentAlignment.MiddleLeft;
            link.UseSelectable = true;
            link.Tag = productWarehouse.Warehouse;
            link.Click += new System.EventHandler(this.metroLink1_Click);

            this.warehousePanel.Controls.Add(link);

            this._index += this._margin;
        }
        #endregion

        private void metroLink1_Click(object sender, System.EventArgs e)
        {
            if (sender is Control control && control.Tag is Warehouse warehouse)
            {
                WarehouseForm warehouseForm = new WarehouseForm();
                warehouseForm.SetEntity(warehouse);
                warehouseForm.ShowDialog();
            }
        }

        private void WarehouseControl_Paint(object sender, PaintEventArgs e)
        {
            if (!this._has)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                PointF[] points =   { new PointF(0, 0), new PointF(160, 0), new PointF(160, 200),
                new PointF(80, 150), new PointF(0, 200) };

                PathGradientBrush gradientBrush = new PathGradientBrush(points, WrapMode.TileFlipX);
                gradientBrush.SurroundColors = new Color[] { Color.Magenta, Color.Crimson, Color.LightYellow, Color.Green, Color.Green };
                gradientBrush.CenterColor = Color.Red;


                using (var format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    using (var font = new Font("Tahoma", 9.5f, FontStyle.Italic))
                    {
                        e.Graphics.DrawString("¡No hay disponibilidad en inventario para este producto!", font, gradientBrush, this.ClientRectangle, format);
                    }
                }
            }
        }
    }
}