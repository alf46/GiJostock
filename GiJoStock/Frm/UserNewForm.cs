using MetroFramework.Forms;
using Ofimatic.Validators;
using System;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class UserNewForm : MetroForm, IFormEvents
    {
        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;

        public UserNewForm()
        {
            this.InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.errorValidator1.Validate())
                {
                    return;
                }

                var user = new User
                {
                    Username = this.txtUsername.Text,
                    Password = this.txtPassword.Text,

                    FirstName = this.txtFirstName.Text,
                    LastName = this.txtLastName.Text,

                    Email = this.txtEmail.Text,
                    Privilege = this.privilegeControl1.Selecteds,
                    Enable = true
                };

                string message = "¿Seguro que desea Agregar este nuevo Usuario?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var repository = new Repository<User>();
                    var userAdded = repository.Add(user);

                    if (userAdded != null)
                    {
                        OnAdded?.Invoke(userAdded, new EventArgs());
                    }

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
            this.errorValidator1.ErrorWhen(this.txtUsername, x => string.IsNullOrWhiteSpace(x.Text), "El nombre de usuario es requerido");
            this.errorValidator1.ErrorWhen(this.txtUsername, x => string.IsNullOrWhiteSpace(x.Text), "El nombre de usuario es requerido");
            this.errorValidator1.ErrorWhen(this.txtPassword, x => string.IsNullOrWhiteSpace(x.Text), "La contraseña es requerida");
            this.errorValidator1.ErrorWhen(this.txtPassword, x => !string.Equals(x.Text, this.txtConfirmPassword.Text), "Las contraseñas no coinciden");
            this.errorValidator1.ErrorWhen(this.txtConfirmPassword, x => !string.Equals(x.Text, this.txtPassword.Text), "Las contraseñas no coinciden");
            this.errorValidator1.ErrorWhen(this.txtEmail, x => !Validators.EmailValidator(x.Text), "El correo electrónicos es inválido");
        }

        private void TxtPassword_ButtonClick(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = !this.txtPassword.UseSystemPasswordChar;
            if (this.txtPassword.UseSystemPasswordChar)
                this.txtPassword.PasswordChar = '●';
            else this.txtPassword.PasswordChar = '\0';
        }
        private void TxtConfirmPassword_ButtonClick(object sender, EventArgs e)
        {
            this.txtConfirmPassword.UseSystemPasswordChar = !this.txtConfirmPassword.UseSystemPasswordChar;
            if (this.txtConfirmPassword.UseSystemPasswordChar)
                this.txtConfirmPassword.PasswordChar = '●';
            else this.txtConfirmPassword.PasswordChar = '\0';
        }
    }
}