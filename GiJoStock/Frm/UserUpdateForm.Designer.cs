namespace GiJoStock.Frm
{
    partial class UserUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdateForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new MetroFramework.Controls.MetroLabel();
            this.ckbEnable = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.linkChangePass = new MetroFramework.Controls.MetroLink();
            this.privilegeControl1 = new GiJoStock.Usercontrol.PrivilegeControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(443, 450);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.txtFirstName.Location = new System.Drawing.Point(23, 97);
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
            this.metroToolTip1.SetToolTip(this.txtFirstName, "Puedes utilizar letras, números y puntos");
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
            this.txtLastName.Location = new System.Drawing.Point(23, 152);
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
            this.metroToolTip1.SetToolTip(this.txtLastName, "Puedes utilizar letras, números y puntos");
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
            this.txtEmail.Location = new System.Drawing.Point(23, 211);
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
            this.metroToolTip1.SetToolTip(this.txtEmail, "Puedes utilizar letras, números y puntos");
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Nombre de usuario";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Nombre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 48;
            this.metroLabel3.Text = "Apellido";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 189);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 50;
            this.metroLabel6.Text = "Email";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiJoStock.Properties.Resources.user_img;
            this.pictureBox1.Location = new System.Drawing.Point(59, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUsername.ForeColor = System.Drawing.Color.Purple;
            this.lbUsername.Location = new System.Drawing.Point(55, 73);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(68, 19);
            this.lbUsername.TabIndex = 55;
            this.lbUsername.Text = "Usuario: ";
            this.lbUsername.UseCustomForeColor = true;
            // 
            // ckbEnable
            // 
            this.ckbEnable.AutoSize = true;
            this.ckbEnable.Location = new System.Drawing.Point(59, 92);
            this.ckbEnable.Name = "ckbEnable";
            this.ckbEnable.Size = new System.Drawing.Size(78, 15);
            this.ckbEnable.TabIndex = 56;
            this.ckbEnable.Text = "Habilitado";
            this.ckbEnable.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.linkChangePass);
            this.metroPanel1.Controls.Add(this.lbUsername);
            this.metroPanel1.Controls.Add(this.ckbEnable);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Location = new System.Drawing.Point(347, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 137);
            this.metroPanel1.TabIndex = 57;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // linkChangePass
            // 
            this.linkChangePass.Location = new System.Drawing.Point(59, 108);
            this.linkChangePass.Name = "linkChangePass";
            this.linkChangePass.Size = new System.Drawing.Size(138, 23);
            this.linkChangePass.TabIndex = 57;
            this.linkChangePass.Text = "Cambiar Contraseña";
            this.linkChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkChangePass.UseSelectable = true;
            this.linkChangePass.Click += new System.EventHandler(this.LinkChangePass_Click);
            // 
            // privilegeControl1
            // 
            this.privilegeControl1.Location = new System.Drawing.Point(23, 294);
            this.privilegeControl1.Name = "privilegeControl1";
            this.privilegeControl1.Size = new System.Drawing.Size(521, 150);
            this.privilegeControl1.TabIndex = 51;
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 496);
            this.Controls.Add(this.metroPanel1);
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
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UserUpdateForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private Usercontrol.PrivilegeControl privilegeControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroCheckBox ckbEnable;
        private MetroFramework.Controls.MetroLabel lbUsername;
        private System.Windows.Forms.Panel metroPanel1;
        private MetroFramework.Controls.MetroLink linkChangePass;
    }
}