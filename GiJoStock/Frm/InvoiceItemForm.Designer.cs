namespace GiJoStock
{
    partial class InvoiceItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceItemForm));
            this.dgvInvoiceItems = new MetroFramework.Controls.MetroGrid();
            this.col_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_detail_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_detail_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCustomerEmail = new MetroFramework.Controls.MetroLabel();
            this.lbCustomerRNC = new MetroFramework.Controls.MetroLabel();
            this.lbCustomerPhone = new MetroFramework.Controls.MetroLabel();
            this.lbCustomerAddress = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lbCustomerName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbAmount = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbItems = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lbReference = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbWarehouse = new MetroFramework.Controls.MetroLabel();
            this.lbInvoiceID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AllowUserToResizeRows = false;
            this.dgvInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInvoiceItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceItems.ColumnHeadersHeight = 20;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_category_id,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.col_entry_detail_stock,
            this.col_entry_detail_name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceItems.EnableHeadersVisualStyles = false;
            this.dgvInvoiceItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInvoiceItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInvoiceItems.Location = new System.Drawing.Point(23, 251);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoiceItems.RowTemplate.Height = 18;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(605, 185);
            this.dgvInvoiceItems.TabIndex = 5;
            // 
            // col_category_id
            // 
            this.col_category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_category_id.DataPropertyName = "ProductID";
            this.col_category_id.HeaderText = "Código";
            this.col_category_id.Name = "col_category_id";
            this.col_category_id.ReadOnly = true;
            this.col_category_id.Width = 69;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PriceStr";
            this.dataGridViewTextBoxColumn15.FillWeight = 80F;
            this.dataGridViewTextBoxColumn15.HeaderText = "Precio Entrada";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 105;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn17.HeaderText = "Total Items";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 86;
            // 
            // col_entry_detail_stock
            // 
            this.col_entry_detail_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_entry_detail_stock.DataPropertyName = "Stock";
            this.col_entry_detail_stock.HeaderText = "Entrada";
            this.col_entry_detail_stock.Name = "col_entry_detail_stock";
            this.col_entry_detail_stock.ReadOnly = true;
            this.col_entry_detail_stock.Width = 71;
            // 
            // col_entry_detail_name
            // 
            this.col_entry_detail_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_entry_detail_name.DataPropertyName = "Name";
            this.col_entry_detail_name.HeaderText = "Nombre";
            this.col_entry_detail_name.Name = "col_entry_detail_name";
            this.col_entry_detail_name.ReadOnly = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lbDate);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.lbAmount);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.lbItems);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.lbUser);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.lbReference);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lbWarehouse);
            this.metroPanel1.Controls.Add(this.lbInvoiceID);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(605, 182);
            this.metroPanel1.TabIndex = 58;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Enabled = false;
            this.lbDate.Location = new System.Drawing.Point(105, 158);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(27, 19);
            this.lbDate.TabIndex = 85;
            this.lbDate.Text = "---";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Enabled = false;
            this.metroLabel15.Location = new System.Drawing.Point(21, 158);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(50, 19);
            this.metroLabel15.TabIndex = 84;
            this.metroLabel15.Text = "Fecha :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCustomerEmail);
            this.panel1.Controls.Add(this.lbCustomerRNC);
            this.panel1.Controls.Add(this.lbCustomerPhone);
            this.panel1.Controls.Add(this.lbCustomerAddress);
            this.panel1.Controls.Add(this.metroLabel16);
            this.panel1.Controls.Add(this.lbCustomerName);
            this.panel1.Location = new System.Drawing.Point(346, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 99);
            this.panel1.TabIndex = 83;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // lbCustomerEmail
            // 
            this.lbCustomerEmail.AutoSize = true;
            this.lbCustomerEmail.Enabled = false;
            this.lbCustomerEmail.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbCustomerEmail.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbCustomerEmail.Location = new System.Drawing.Point(12, 73);
            this.lbCustomerEmail.Name = "lbCustomerEmail";
            this.lbCustomerEmail.Size = new System.Drawing.Size(33, 15);
            this.lbCustomerEmail.TabIndex = 85;
            this.lbCustomerEmail.Text = "Email";
            this.lbCustomerEmail.UseCustomForeColor = true;
            // 
            // lbCustomerRNC
            // 
            this.lbCustomerRNC.AutoSize = true;
            this.lbCustomerRNC.Enabled = false;
            this.lbCustomerRNC.Location = new System.Drawing.Point(64, 8);
            this.lbCustomerRNC.Name = "lbCustomerRNC";
            this.lbCustomerRNC.Size = new System.Drawing.Size(27, 19);
            this.lbCustomerRNC.TabIndex = 84;
            this.lbCustomerRNC.Text = "---";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Enabled = false;
            this.lbCustomerPhone.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbCustomerPhone.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbCustomerPhone.Location = new System.Drawing.Point(12, 58);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(48, 15);
            this.lbCustomerPhone.TabIndex = 81;
            this.lbCustomerPhone.Text = "Teléfono";
            this.lbCustomerPhone.UseCustomForeColor = true;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Enabled = false;
            this.lbCustomerAddress.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbCustomerAddress.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbCustomerAddress.Location = new System.Drawing.Point(12, 43);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(52, 15);
            this.lbCustomerAddress.TabIndex = 79;
            this.lbCustomerAddress.Text = "Dirección";
            this.lbCustomerAddress.UseCustomForeColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Enabled = false;
            this.metroLabel16.Location = new System.Drawing.Point(11, 8);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(47, 19);
            this.metroLabel16.TabIndex = 77;
            this.metroLabel16.Text = "RNC : ";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Enabled = false;
            this.lbCustomerName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbCustomerName.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbCustomerName.Location = new System.Drawing.Point(12, 28);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(40, 15);
            this.lbCustomerName.TabIndex = 75;
            this.lbCustomerName.Text = "Cliente";
            this.lbCustomerName.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Gainsboro;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.metroLabel3.Location = new System.Drawing.Point(346, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 79;
            this.metroLabel3.Text = "CLIENTE";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.BlueViolet;
            this.lbAmount.Enabled = false;
            this.lbAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(92, 51);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(33, 19);
            this.lbAmount.TabIndex = 77;
            this.lbAmount.Text = "093";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAmount.UseCustomBackColor = true;
            this.lbAmount.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Gray;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(21, 51);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 76;
            this.metroLabel4.Text = "MONTO : ";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.Enabled = false;
            this.lbItems.Location = new System.Drawing.Point(105, 139);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(27, 19);
            this.lbItems.TabIndex = 74;
            this.lbItems.Text = "---";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Enabled = false;
            this.metroLabel14.Location = new System.Drawing.Point(21, 139);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(51, 19);
            this.metroLabel14.TabIndex = 73;
            this.metroLabel14.Text = "Items : ";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Enabled = false;
            this.lbUser.Location = new System.Drawing.Point(105, 120);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(27, 19);
            this.lbUser.TabIndex = 69;
            this.lbUser.Text = "---";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Enabled = false;
            this.metroLabel10.Location = new System.Drawing.Point(21, 120);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 68;
            this.metroLabel10.Text = "Usuario:";
            // 
            // lbReference
            // 
            this.lbReference.AutoSize = true;
            this.lbReference.Enabled = false;
            this.lbReference.Location = new System.Drawing.Point(105, 101);
            this.lbReference.Name = "lbReference";
            this.lbReference.Size = new System.Drawing.Size(27, 19);
            this.lbReference.TabIndex = 67;
            this.lbReference.Text = "---";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Enabled = false;
            this.metroLabel7.Location = new System.Drawing.Point(21, 101);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Referencia : ";
            // 
            // lbWarehouse
            // 
            this.lbWarehouse.AutoSize = true;
            this.lbWarehouse.Enabled = false;
            this.lbWarehouse.Location = new System.Drawing.Point(105, 82);
            this.lbWarehouse.Name = "lbWarehouse";
            this.lbWarehouse.Size = new System.Drawing.Size(27, 19);
            this.lbWarehouse.TabIndex = 63;
            this.lbWarehouse.Text = "---";
            // 
            // lbInvoiceID
            // 
            this.lbInvoiceID.AutoSize = true;
            this.lbInvoiceID.BackColor = System.Drawing.Color.BlueViolet;
            this.lbInvoiceID.Enabled = false;
            this.lbInvoiceID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbInvoiceID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbInvoiceID.ForeColor = System.Drawing.Color.White;
            this.lbInvoiceID.Location = new System.Drawing.Point(239, 16);
            this.lbInvoiceID.Name = "lbInvoiceID";
            this.lbInvoiceID.Size = new System.Drawing.Size(42, 25);
            this.lbInvoiceID.TabIndex = 62;
            this.lbInvoiceID.Text = "093";
            this.lbInvoiceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbInvoiceID.UseCustomBackColor = true;
            this.lbInvoiceID.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(21, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Alamacén : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Gray;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(21, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(221, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "NÚMERO DE FACTURA : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Imprimir";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // InvoiceItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 459);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InvoiceItemForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Detalle de la Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvInvoiceItems;
        private System.Windows.Forms.Panel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbInvoiceID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbWarehouse;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lbUser;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel lbReference;
        private MetroFramework.Controls.MetroLabel lbItems;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_entry_detail_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_entry_detail_name;
        private MetroFramework.Controls.MetroLabel lbAmount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lbCustomerPhone;
        private MetroFramework.Controls.MetroLabel lbCustomerAddress;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lbCustomerName;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel lbCustomerEmail;
        private MetroFramework.Controls.MetroLabel lbCustomerRNC;
    }
}