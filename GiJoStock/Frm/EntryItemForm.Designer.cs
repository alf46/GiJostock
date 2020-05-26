namespace GiJoStock
{
    partial class EntryItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryItemForm));
            this.dgvEntryItems = new MetroFramework.Controls.MetroGrid();
            this.col_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_detail_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_entry_detail_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lbItems = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lbObservations = new System.Windows.Forms.Label();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lbReference = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lbDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbWarehouse = new MetroFramework.Controls.MetroLabel();
            this.lbEntryID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryItems)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntryItems
            // 
            this.dgvEntryItems.AllowUserToAddRows = false;
            this.dgvEntryItems.AllowUserToDeleteRows = false;
            this.dgvEntryItems.AllowUserToResizeRows = false;
            this.dgvEntryItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntryItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntryItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEntryItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntryItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEntryItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntryItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntryItems.ColumnHeadersHeight = 20;
            this.dgvEntryItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEntryItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvEntryItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntryItems.EnableHeadersVisualStyles = false;
            this.dgvEntryItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEntryItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEntryItems.Location = new System.Drawing.Point(23, 207);
            this.dgvEntryItems.MultiSelect = false;
            this.dgvEntryItems.Name = "dgvEntryItems";
            this.dgvEntryItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntryItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntryItems.RowHeadersVisible = false;
            this.dgvEntryItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEntryItems.RowTemplate.Height = 18;
            this.dgvEntryItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntryItems.Size = new System.Drawing.Size(575, 158);
            this.dgvEntryItems.TabIndex = 5;
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
            this.metroPanel1.Controls.Add(this.lbItems);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.lbObservations);
            this.metroPanel1.Controls.Add(this.lbUser);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.lbReference);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.lbDate);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.lbWarehouse);
            this.metroPanel1.Controls.Add(this.lbEntryID);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(575, 138);
            this.metroPanel1.TabIndex = 58;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(470, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Imprimir";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.lbItems.Enabled = false;
            this.lbItems.Location = new System.Drawing.Point(108, 108);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(27, 19);
            this.lbItems.TabIndex = 74;
            this.lbItems.Text = "---";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Enabled = false;
            this.metroLabel14.Location = new System.Drawing.Point(21, 108);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(51, 19);
            this.metroLabel14.TabIndex = 73;
            this.metroLabel14.Text = "Items : ";
            // 
            // lbObservations
            // 
            this.lbObservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservations.ForeColor = System.Drawing.Color.DimGray;
            this.lbObservations.Location = new System.Drawing.Point(337, 51);
            this.lbObservations.Name = "lbObservations";
            this.lbObservations.Size = new System.Drawing.Size(232, 76);
            this.lbObservations.TabIndex = 70;
            this.lbObservations.Text = "ObservacionesObservacionesObservacionesObservacionesObservaciones";
            this.lbObservations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbObservations.Visible = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Enabled = false;
            this.lbUser.Location = new System.Drawing.Point(108, 89);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(27, 19);
            this.lbUser.TabIndex = 69;
            this.lbUser.Text = "---";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Enabled = false;
            this.metroLabel10.Location = new System.Drawing.Point(21, 89);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(56, 19);
            this.metroLabel10.TabIndex = 68;
            this.metroLabel10.Text = "Usuario:";
            // 
            // lbReference
            // 
            this.lbReference.AutoSize = true;
            this.lbReference.Enabled = false;
            this.lbReference.Location = new System.Drawing.Point(108, 70);
            this.lbReference.Name = "lbReference";
            this.lbReference.Size = new System.Drawing.Size(27, 19);
            this.lbReference.TabIndex = 67;
            this.lbReference.Text = "---";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Enabled = false;
            this.metroLabel7.Location = new System.Drawing.Point(21, 70);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(81, 19);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Referencia : ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Enabled = false;
            this.lbDate.Location = new System.Drawing.Point(400, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(27, 19);
            this.lbDate.TabIndex = 65;
            this.lbDate.Text = "---";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.Location = new System.Drawing.Point(340, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Fecha : ";
            // 
            // lbWarehouse
            // 
            this.lbWarehouse.AutoSize = true;
            this.lbWarehouse.Enabled = false;
            this.lbWarehouse.Location = new System.Drawing.Point(108, 51);
            this.lbWarehouse.Name = "lbWarehouse";
            this.lbWarehouse.Size = new System.Drawing.Size(27, 19);
            this.lbWarehouse.TabIndex = 63;
            this.lbWarehouse.Text = "---";
            // 
            // lbEntryID
            // 
            this.lbEntryID.AutoSize = true;
            this.lbEntryID.BackColor = System.Drawing.Color.BlueViolet;
            this.lbEntryID.Enabled = false;
            this.lbEntryID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbEntryID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbEntryID.ForeColor = System.Drawing.Color.White;
            this.lbEntryID.Location = new System.Drawing.Point(239, 16);
            this.lbEntryID.Name = "lbEntryID";
            this.lbEntryID.Size = new System.Drawing.Size(42, 25);
            this.lbEntryID.TabIndex = 62;
            this.lbEntryID.Text = "093";
            this.lbEntryID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbEntryID.UseCustomBackColor = true;
            this.lbEntryID.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(21, 51);
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
            this.metroLabel1.Size = new System.Drawing.Size(226, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "NÚMERO DE ENTRADA : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // EntryItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 388);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvEntryItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntryItemForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Detalle de la Entrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryItems)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvEntryItems;
        private System.Windows.Forms.Panel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbEntryID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbWarehouse;
        private MetroFramework.Controls.MetroLabel lbDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.Label lbObservations;
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
    }
}