namespace GiJoStock.Frm
{
    partial class UserNewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNewForm));
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.privilegeControl1 = new GiJoStock.Usercontrol.PrivilegeControl();
            this.errorValidator1 = new Ofimatic.Framework.Controls.ErrorValidator();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(23, 98);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Nombre de usuario";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.ShowClearButton = true;
            this.txtUsername.Size = new System.Drawing.Size(177, 23);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.WaterMark = "Nombre de usuario";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 76);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Usuario";
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
            this.btnSave.Location = new System.Drawing.Point(443, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.DisplayIcon = true;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(226, 100);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "Nombre de usuario";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.ShowClearButton = true;
            this.txtFirstName.Size = new System.Drawing.Size(318, 23);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMark = "Nombre de usuario";
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = global::GiJoStock.Properties.Resources.search;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.DisplayIcon = true;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(226, 160);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Nombre de usuario";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.ShowClearButton = true;
            this.txtLastName.Size = new System.Drawing.Size(318, 23);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Nombre de usuario";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtEmail.Location = new System.Drawing.Point(226, 222);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Nombre de usuario";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.ShowClearButton = true;
            this.txtEmail.Size = new System.Drawing.Size(318, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Nombre de usuario";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = global::GiJoStock.Properties.Resources.show_pass;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(23, 160);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Contraseña";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.ShowButton = true;
            this.txtPassword.ShowClearButton = true;
            this.txtPassword.Size = new System.Drawing.Size(177, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Contraseña";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtPassword_ButtonClick);
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = global::GiJoStock.Properties.Resources.show_pass;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.DisplayIcon = true;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(23, 222);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PromptText = "Confirmar Contraseña";
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.ShowButton = true;
            this.txtConfirmPassword.ShowClearButton = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(177, 23);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.WaterMark = "Confirmar Contraseña";
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtConfirmPassword_ButtonClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(226, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(226, 138);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Apellido";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(226, 200);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Email";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Contraseña";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 198);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(139, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "Confirmar Contraseña";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroLabel7.Location = new System.Drawing.Point(23, 261);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(156, 19);
            this.metroLabel7.TabIndex = 52;
            this.metroLabel7.Text = "Privilegios de Usuario";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(23, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 10);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // privilegeControl1
            // 
            this.privilegeControl1.Location = new System.Drawing.Point(23, 294);
            this.privilegeControl1.Name = "privilegeControl1";
            this.privilegeControl1.Size = new System.Drawing.Size(521, 150);
            this.privilegeControl1.TabIndex = 51;
            // 
            // errorValidator1
            // 
            this.errorValidator1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorValidator1.ContainerControl = this;
            this.errorValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidator1.Icon")));
            this.errorValidator1.TimerError = 5000;
            // 
            // UserNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.privilegeControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.metroLabel4);
            this.MaximizeBox = false;
            this.Name = "UserNewForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Agregar Nuevo Usuario";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Usercontrol.PrivilegeControl privilegeControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private Ofimatic.Framework.Controls.ErrorValidator errorValidator1;
    }
}