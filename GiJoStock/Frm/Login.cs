using GiJoStock.Repositories;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            this.InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtUsername.Text)
                    || string.IsNullOrWhiteSpace(this.txtPassword.Text))
                {
                    return;
                }

                this.metroProgressBar.ProgressBarStyle = ProgressBarStyle.Marquee;
                this.metroProgressBar.Value = 50;
                this.metroProgressBar.Visible = true;

                // Autenticar el usuario con la base de datos.
                var userRepo = new UserRepository();
                userRepo.Login(this.txtUsername.Text, this.txtPassword.Text);

                this.metroProgressBar.ProgressBarStyle = ProgressBarStyle.Continuous;
                this.metroProgressBar.Value = 0;
                this.metroProgressBar.Visible = false;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Exception ex)
            {
                this.metroProgressBar.ProgressBarStyle = ProgressBarStyle.Continuous;
                this.metroProgressBar.Value = 0;
                this.metroProgressBar.Visible = false;

                ex.ShowDialog();
            }
        }

        private void LinkChangePass_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.txtUsername.Text))
                {
                    var users = new UserRepository().GetAll();
                    var user = users?.FirstOrDefault(x => x.Username.Equals(this.txtUsername.Text));
                    if (user == null)
                    {
                        throw new Exception("Debe espesificar un usuario valido");
                    }
                    UserResetPasswordForm resetPasswordForm = new UserResetPasswordForm(user);
                    resetPasswordForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}