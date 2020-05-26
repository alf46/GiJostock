namespace GiJoStock.Frm
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbkEnable = new MetroFramework.Controls.MetroCheckBox();
            this.txtDocument = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.errorValidator1 = new Ofimatic.Framework.Controls.ErrorValidator();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 10);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtName.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DisplayIcon = true;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(23, 98);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Nombre del Supplier o Cliente";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.ShowClearButton = true;
            this.txtName.Size = new System.Drawing.Size(318, 23);
            this.txtName.TabIndex = 3;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Nombre del Supplier o Cliente";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 76);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Nombre";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.DisplayIcon = true;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(23, 157);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "Teléfono del Supplier o Cliente";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.ShowClearButton = true;
            this.txtPhone.Size = new System.Drawing.Size(318, 23);
            this.txtPhone.TabIndex = 54;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "Teléfono del Supplier o Cliente";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 135);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 55;
            this.metroLabel1.Text = "Teléfono";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.DisplayIcon = true;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(24, 216);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Correo Electronico del Supplier o Cliente";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(318, 23);
            this.txtEmail.TabIndex = 56;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Correo Electronico del Supplier o Cliente";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 194);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Correo";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(77, 77);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.DisplayIcon = true;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(347, 98);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Dirección del Supplier o Cliente";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.ShowClearButton = true;
            this.txtAddress.Size = new System.Drawing.Size(197, 82);
            this.txtAddress.TabIndex = 58;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Dirección del Supplier o Cliente";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(347, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Dirección";
            // 
            // cbkEnable
            // 
            this.cbkEnable.AutoSize = true;
            this.cbkEnable.Checked = true;
            this.cbkEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbkEnable.Location = new System.Drawing.Point(347, 259);
            this.cbkEnable.Name = "cbkEnable";
            this.cbkEnable.Size = new System.Drawing.Size(78, 15);
            this.cbkEnable.TabIndex = 60;
            this.cbkEnable.Text = "Habilidato";
            this.cbkEnable.UseSelectable = true;
            // 
            // txtDocument
            // 
            // 
            // 
            // 
            this.txtDocument.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtDocument.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txtDocument.CustomButton.Name = "";
            this.txtDocument.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocument.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocument.CustomButton.TabIndex = 1;
            this.txtDocument.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocument.CustomButton.UseSelectable = true;
            this.txtDocument.CustomButton.Visible = false;
            this.txtDocument.DisplayIcon = true;
            this.txtDocument.Lines = new string[0];
            this.txtDocument.Location = new System.Drawing.Point(347, 216);
            this.txtDocument.MaxLength = 32767;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.PasswordChar = '\0';
            this.txtDocument.PromptText = "RNC o Cédula";
            this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocument.SelectedText = "";
            this.txtDocument.SelectionLength = 0;
            this.txtDocument.SelectionStart = 0;
            this.txtDocument.ShortcutsEnabled = true;
            this.txtDocument.ShowClearButton = true;
            this.txtDocument.Size = new System.Drawing.Size(197, 23);
            this.txtDocument.TabIndex = 61;
            this.txtDocument.UseSelectable = true;
            this.txtDocument.WaterMark = "RNC o Cédula";
            this.txtDocument.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocument.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(347, 194);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "RNC o Cédula";
            // 
            // errorValidator1
            // 
            this.errorValidator1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorValidator1.ContainerControl = this;
            this.errorValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidator1.Icon")));
            this.errorValidator1.TimerError = 5000;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 297);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbkEnable);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "SupplierForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Agregar Nuevo Supplidor";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox cbkEnable;
        private MetroFramework.Controls.MetroTextBox txtDocument;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private Ofimatic.Framework.Controls.ErrorValidator errorValidator1;
    }
}