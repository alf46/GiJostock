namespace GiJoStock
{
    partial class WarehouseFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseFilterForm));
            this.dgvWarehouses = new MetroFramework.Controls.MetroGrid();
            this.col_warehouse_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouse_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_warehouse_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWarehouses
            // 
            this.dgvWarehouses.AllowUserToAddRows = false;
            this.dgvWarehouses.AllowUserToDeleteRows = false;
            this.dgvWarehouses.AllowUserToResizeRows = false;
            this.dgvWarehouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWarehouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWarehouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWarehouses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvWarehouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWarehouses.ColumnHeadersHeight = 30;
            this.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvWarehouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_warehouse_id,
            this.col_warehouse_name,
            this.col_warehouse_phone,
            this.col_warehouse_address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWarehouses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWarehouses.EnableHeadersVisualStyles = false;
            this.dgvWarehouses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvWarehouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWarehouses.Location = new System.Drawing.Point(23, 63);
            this.dgvWarehouses.MultiSelect = false;
            this.dgvWarehouses.Name = "dgvWarehouses";
            this.dgvWarehouses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWarehouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWarehouses.RowHeadersVisible = false;
            this.dgvWarehouses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvWarehouses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouses.Size = new System.Drawing.Size(575, 205);
            this.dgvWarehouses.TabIndex = 5;
            // 
            // col_warehouse_id
            // 
            this.col_warehouse_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_warehouse_id.DataPropertyName = "ID";
            this.col_warehouse_id.HeaderText = "Código";
            this.col_warehouse_id.Name = "col_warehouse_id";
            this.col_warehouse_id.ReadOnly = true;
            this.col_warehouse_id.Width = 69;
            // 
            // col_warehouse_name
            // 
            this.col_warehouse_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_warehouse_name.DataPropertyName = "Name";
            this.col_warehouse_name.FillWeight = 80F;
            this.col_warehouse_name.HeaderText = "Nombre";
            this.col_warehouse_name.Name = "col_warehouse_name";
            this.col_warehouse_name.ReadOnly = true;
            this.col_warehouse_name.Width = 72;
            // 
            // col_warehouse_phone
            // 
            this.col_warehouse_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_warehouse_phone.DataPropertyName = "Phone";
            this.col_warehouse_phone.HeaderText = "Teléfono";
            this.col_warehouse_phone.Name = "col_warehouse_phone";
            this.col_warehouse_phone.ReadOnly = true;
            this.col_warehouse_phone.Width = 76;
            // 
            // col_warehouse_address
            // 
            this.col_warehouse_address.DataPropertyName = "Address";
            this.col_warehouse_address.HeaderText = "Dirección";
            this.col_warehouse_address.Name = "col_warehouse_address";
            this.col_warehouse_address.ReadOnly = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(23, 274);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(143, 23);
            this.btnSelect.TabIndex = 46;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSelect.UseSelectable = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtName.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Icon = global::GiJoStock.Properties.Resources.deparment;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(23, 29);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Búsqueda...";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(303, 23);
            this.txtName.TabIndex = 47;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Búsqueda...";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // WarehouseFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 309);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgvWarehouses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WarehouseFilterForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Búsqueda de Almacén";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private MetroFramework.Controls.MetroGrid dgvWarehouses;
        private MetroFramework.Controls.MetroButton btnSelect;
        private MetroFramework.Controls.MetroTextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouse_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouse_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouse_address;
    }
}