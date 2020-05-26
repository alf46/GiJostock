namespace GiJoStock.Frm
{
    partial class OfficeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpAdding = new MetroFramework.Controls.MetroProgressSpinner();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDeparment = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmployees = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtManager = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.validator1 = new GiJoStock.Validator();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 10);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // SpAdding
            // 
            this.SpAdding.Location = new System.Drawing.Point(255, 211);
            this.SpAdding.Maximum = 100;
            this.SpAdding.Name = "SpAdding";
            this.SpAdding.Size = new System.Drawing.Size(16, 16);
            this.SpAdding.TabIndex = 35;
            this.SpAdding.UseSelectable = true;
            this.SpAdding.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Guardar";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 83);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(280, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Departamento";
            // 
            // txtDeparment
            // 
            // 
            // 
            // 
            this.txtDeparment.CustomButton.Image = global::GiJoStock.Properties.Resources.icons8_búsqueda_16;
            this.txtDeparment.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtDeparment.CustomButton.Name = "";
            this.txtDeparment.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDeparment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeparment.CustomButton.TabIndex = 1;
            this.txtDeparment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeparment.CustomButton.UseSelectable = true;
            this.txtDeparment.CustomButton.Visible = false;
            this.txtDeparment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Department", true));
            this.txtDeparment.DisplayIcon = true;
            this.txtDeparment.Icon = global::GiJoStock.Properties.Resources.icons8_departamento_15;
            this.txtDeparment.Lines = new string[0];
            this.txtDeparment.Location = new System.Drawing.Point(280, 107);
            this.txtDeparment.MaxLength = 32767;
            this.txtDeparment.Name = "txtDeparment";
            this.txtDeparment.PasswordChar = '\0';
            this.txtDeparment.PromptText = "Nombre del producto";
            this.txtDeparment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeparment.SelectedText = "";
            this.txtDeparment.SelectionLength = 0;
            this.txtDeparment.SelectionStart = 0;
            this.txtDeparment.ShortcutsEnabled = true;
            this.txtDeparment.ShowClearButton = true;
            this.txtDeparment.Size = new System.Drawing.Size(215, 23);
            this.txtDeparment.TabIndex = 36;
            this.txtDeparment.UseSelectable = true;
            this.txtDeparment.WaterMark = "Nombre del producto";
            this.txtDeparment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeparment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = global::GiJoStock.Properties.Resources.icons8_búsqueda_16;
            this.txtName.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.txtName.DisplayIcon = true;
            this.txtName.Icon = global::GiJoStock.Properties.Resources.icons8_departamento_15;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(36, 107);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Nombre del producto";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 29;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Nombre del producto";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmployees
            // 
            // 
            // 
            // 
            this.txtEmployees.CustomButton.Image = global::GiJoStock.Properties.Resources.icons8_búsqueda_16;
            this.txtEmployees.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtEmployees.CustomButton.Name = "";
            this.txtEmployees.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmployees.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmployees.CustomButton.TabIndex = 1;
            this.txtEmployees.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmployees.CustomButton.UseSelectable = true;
            this.txtEmployees.CustomButton.Visible = false;
            this.txtEmployees.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Employees", true));
            this.txtEmployees.DisplayIcon = true;
            this.txtEmployees.Icon = global::GiJoStock.Properties.Resources.icons8_departamento_15;
            this.txtEmployees.Lines = new string[0];
            this.txtEmployees.Location = new System.Drawing.Point(280, 167);
            this.txtEmployees.MaxLength = 32767;
            this.txtEmployees.Name = "txtEmployees";
            this.txtEmployees.PasswordChar = '\0';
            this.txtEmployees.PromptText = "Número de Empleados";
            this.txtEmployees.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmployees.SelectedText = "";
            this.txtEmployees.SelectionLength = 0;
            this.txtEmployees.SelectionStart = 0;
            this.txtEmployees.ShortcutsEnabled = true;
            this.txtEmployees.ShowClearButton = true;
            this.txtEmployees.Size = new System.Drawing.Size(215, 23);
            this.txtEmployees.TabIndex = 37;
            this.txtEmployees.UseSelectable = true;
            this.txtEmployees.WaterMark = "Número de Empleados";
            this.txtEmployees.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmployees.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(280, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Número de Empleados";
            // 
            // txtManager
            // 
            // 
            // 
            // 
            this.txtManager.CustomButton.Image = global::GiJoStock.Properties.Resources.icons8_búsqueda_16;
            this.txtManager.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtManager.CustomButton.Name = "";
            this.txtManager.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtManager.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManager.CustomButton.TabIndex = 1;
            this.txtManager.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManager.CustomButton.UseSelectable = true;
            this.txtManager.CustomButton.Visible = false;
            this.txtManager.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Manager", true));
            this.txtManager.DisplayIcon = true;
            this.txtManager.Icon = global::GiJoStock.Properties.Resources.icons8_departamento_15;
            this.txtManager.Lines = new string[0];
            this.txtManager.Location = new System.Drawing.Point(38, 167);
            this.txtManager.MaxLength = 32767;
            this.txtManager.Name = "txtManager";
            this.txtManager.PasswordChar = '\0';
            this.txtManager.PromptText = "Número de Empleados";
            this.txtManager.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManager.SelectedText = "";
            this.txtManager.SelectionLength = 0;
            this.txtManager.SelectionStart = 0;
            this.txtManager.ShortcutsEnabled = true;
            this.txtManager.ShowClearButton = true;
            this.txtManager.Size = new System.Drawing.Size(215, 23);
            this.txtManager.TabIndex = 39;
            this.txtManager.UseSelectable = true;
            this.txtManager.WaterMark = "Número de Empleados";
            this.txtManager.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManager.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 40;
            this.metroLabel3.Text = "Administrador";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "Enable", true));
            this.metroCheckBox1.Location = new System.Drawing.Point(280, 212);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(56, 15);
            this.metroCheckBox1.TabIndex = 41;
            this.metroCheckBox1.Text = "Activa";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // validator1
            // 
            this.validator1.ContainerControl = this;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(GiJoStock.DataModel.Data.Office);
            // 
            // OfficeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 259);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtEmployees);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtDeparment);
            this.Controls.Add(this.SpAdding);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OfficeForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Nueva Oficina";
            this.Load += new System.EventHandler(this.OfficeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroProgressSpinner SpAdding;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDeparment;
        private MetroFramework.Controls.MetroTextBox txtEmployees;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtManager;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private System.Windows.Forms.BindingSource bindingSource;
        private Validator validator1;
    }
}