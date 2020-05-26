namespace GiJoStock.Frm
{
    partial class UserResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserResetPasswordForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorValidator1 = new Ofimatic.Framework.Controls.ErrorValidator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-18, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Cambiar Contraseña";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiJoStock.Properties.Resources.user_img;
            this.pictureBox1.Location = new System.Drawing.Point(35, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbUsername.ForeColor = System.Drawing.Color.Purple;
            this.lbUsername.Location = new System.Drawing.Point(3, 39);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(96, 19);
            this.lbUsername.TabIndex = 55;
            this.lbUsername.Text = "Usuario";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUsername.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.txtNewPassword);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtConfirmNewPassword);
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Location = new System.Drawing.Point(23, 74);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(470, 241);
            this.metroPanel1.TabIndex = 57;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 67);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanel_Paint);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = global::GiJoStock.Properties.Resources.show_pass;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.DisplayIcon = true;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(165, 104);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PromptText = "Nueva Contraseña";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.ShowButton = true;
            this.txtNewPassword.ShowClearButton = true;
            this.txtNewPassword.Size = new System.Drawing.Size(222, 23);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WaterMark = "Nueva Contraseña";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNewPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtViewPassword_ButtonClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(165, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Nueva Contraseña";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Enabled = false;
            this.metroLabel5.Location = new System.Drawing.Point(165, 141);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(180, 19);
            this.metroLabel5.TabIndex = 61;
            this.metroLabel5.Text = "Confirmar Nueva Contraseña";
            // 
            // txtConfirmNewPassword
            // 
            // 
            // 
            // 
            this.txtConfirmNewPassword.CustomButton.Image = global::GiJoStock.Properties.Resources.show_pass;
            this.txtConfirmNewPassword.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtConfirmNewPassword.CustomButton.Name = "";
            this.txtConfirmNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmNewPassword.CustomButton.TabIndex = 1;
            this.txtConfirmNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmNewPassword.CustomButton.UseSelectable = true;
            this.txtConfirmNewPassword.DisplayIcon = true;
            this.txtConfirmNewPassword.Lines = new string[0];
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(165, 165);
            this.txtConfirmNewPassword.MaxLength = 32767;
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '●';
            this.txtConfirmNewPassword.PromptText = "Confirmar Nueva Contraseña";
            this.txtConfirmNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmNewPassword.SelectedText = "";
            this.txtConfirmNewPassword.SelectionLength = 0;
            this.txtConfirmNewPassword.SelectionStart = 0;
            this.txtConfirmNewPassword.ShortcutsEnabled = true;
            this.txtConfirmNewPassword.ShowButton = true;
            this.txtConfirmNewPassword.ShowClearButton = true;
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(222, 23);
            this.txtConfirmNewPassword.TabIndex = 2;
            this.txtConfirmNewPassword.UseSelectable = true;
            this.txtConfirmNewPassword.UseSystemPasswordChar = true;
            this.txtConfirmNewPassword.WaterMark = "Confirmar Nueva Contraseña";
            this.txtConfirmNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmNewPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtViewPassword_ButtonClick);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = global::GiJoStock.Properties.Resources.show_pass;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(165, 44);
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
            this.txtPassword.Size = new System.Drawing.Size(222, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Contraseña";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtViewPassword_ButtonClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(165, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Contraseña Actual";
            // 
            // errorValidator1
            // 
            this.errorValidator1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorValidator1.ContainerControl = this;
            this.errorValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorValidator1.Icon")));
            this.errorValidator1.TimerError = 5000;
            // 
            // UserResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 338);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UserResetPasswordForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Actualizar Contraseña de Usuario";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lbUsername;
        private System.Windows.Forms.Panel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtConfirmNewPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private Ofimatic.Framework.Controls.ErrorValidator errorValidator1;
    }
}