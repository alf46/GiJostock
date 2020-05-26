using GiJoStock.Repositories;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class UserResetPasswordForm : MetroForm
    {
        private readonly User user;

        public UserResetPasswordForm(User user)
        {
            this.InitializeComponent();
            this.user = user;

            this.lbUsername.Text = this.user.Username;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                string message = "¿Seguro que desea actualizar la constraseña de usuario?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var pass = this.txtPassword.Text;
                    var newPass = this.txtNewPassword.Text;
                    var confirmNewPass = this.txtConfirmNewPassword.Text;

                    var userRepo = new UserRepository();
                    userRepo.ResetPassword(this.user.ID, pass, newPass, confirmNewPass);

                    Helpers.ShowDialog("!Contraseña actualizada correctamente!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.errorValidator1.ErrorWhen(this.txtPassword, x => string.IsNullOrWhiteSpace(x.Text), "La contraseña actual es requerida");

            this.errorValidator1.ErrorWhen(this.txtNewPassword, x => string.IsNullOrWhiteSpace(x.Text), "La nueva contraseña es requerida");
            this.errorValidator1.ErrorWhen(this.txtNewPassword, x => !string.Equals(x.Text, this.txtConfirmNewPassword.Text), "Las contraseñas no coinciden");

            this.errorValidator1.ErrorWhen(this.txtConfirmNewPassword, x => string.IsNullOrWhiteSpace(x.Text), "La confirmación de la nueva contraseña es requerida");
            this.errorValidator1.ErrorWhen(this.txtConfirmNewPassword, x => !string.Equals(x.Text, this.txtNewPassword.Text), "Las contraseñas no coinciden");
        }

        private void BorderPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void TxtViewPassword_ButtonClick(object sender, EventArgs e)
        {
            var metroTextBox = sender as MetroTextBox;
            metroTextBox.UseSystemPasswordChar = !metroTextBox.UseSystemPasswordChar;
            if (metroTextBox.UseSystemPasswordChar)
                metroTextBox.PasswordChar = '●';
            else metroTextBox.PasswordChar = '\0';
        }
    }
}