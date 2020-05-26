using GiJoStock.Repositories;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GiJoStock.Frm
{
    public partial class UserUpdateForm : MetroForm, IForm<User>, IFormEvents
    {
        private readonly Repository<User> repository;
        private User user;

        public UserUpdateForm()
        {
            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.EditUser))
            {
                throw new Exception("Este usuario no tiene privilegio para realizar esta operación");
            }

            this.InitializeComponent();

            this.repository = new Repository<User>();
        }

        public event EventHandler<EventArgs> OnAdded;
        public event EventHandler<EventArgs> OnUpdate;

        public void SetEntity(User source)
        {
            this.user = source;

            this.lbUsername.Text = this.user.Username;

            this.txtFirstName.Text = this.user.FirstName;
            this.txtLastName.Text = this.user.LastName;
            this.txtEmail.Text = this.user.Email;

            this.ckbEnable.Checked = this.user.Enable;

            this.privilegeControl1.SelectPrivileges(this.user.Privilege);

            if (!UserRepository.LoggedUser.HasPrivilege(Privilege.EditUser))
            {
                this.privilegeControl1.Enabled = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!this.validator1.Validate())
                {
                    //    return;
                }

                this.user.FirstName = this.txtFirstName.Text;
                this.user.LastName = this.txtLastName.Text;
                this.user.Email = this.txtEmail.Text;

                this.user.Privilege = this.privilegeControl1.Selecteds;
                this.user.Enable = this.ckbEnable.Checked;

                string message = "¿Seguro que desea Agregar este nuevo Usuario?";
                DialogResult dialogResult = Helpers.ShowDialog(message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var updated = this.repository.Update(this.user);
                    if (updated != null)
                    {
                        OnUpdate?.Invoke(updated, new EventArgs());
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
            //this.validator1.AddValidation(this.txtEmail, x => !Validators.EmailValidator(x.Text), "El correo electrónicos es inválido");
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = e.ClipRectangle;
            borderRectangle.Inflate(-1, -1);

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        private void LinkChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                UserResetPasswordForm resetPasswordForm = new UserResetPasswordForm(this.user);
                resetPasswordForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.ShowDialog();
            }
        }
    }
}