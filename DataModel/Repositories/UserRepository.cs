using DataModel.Repositories;
using DataModel.StockDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel
{
    public class UserRepository : IRepository<User>
    {
        #region Attributes
        private readonly ApplicationDbContext _context;
        #endregion

        #region Constructors
        public UserRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        #endregion

        #region Public Methods
        public Task Add(User source)
        {
            this._context.Entry(source).State = EntityState.Added;
            return this._context.SaveChangesAsync();

        }

        public async Task<User> Disable(int id)
        {
            var source = await this._context.Users.FindAsync(id);
            if (source != null)
            {
                source.Enable = false;
                await this._context.SaveChangesAsync();
            }

            return source;
        }


        public Task<User> Get(int id)
        {
            return this._context.Users.FindAsync(id).AsTask();
        }

        public Task<List<User>> GetAll()
        {
            return this._context.Users.ToListAsync();
        }

        public async Task<User> Update(int id, User source)
        {
            this._context.Entry(source).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return source;
        }

        public async Task<User> ResetPassword(int id, ChangePassword resetPassword)
        {
            // Validar contraseña.
            if (string.IsNullOrWhiteSpace(resetPassword?.Password)
                || string.IsNullOrWhiteSpace(resetPassword?.NewPassword))
            {
                throw new GiJoException("Contraseña Incorrecta");
            }

            // Validar contraseña.
            if (!string.Equals(resetPassword.NewPassword, resetPassword.ConfirmNewPassword))
            {
                throw new GiJoException("Las Contraseñas no concuerdan");
            }

            // Validar el usuario.
            var user = await this._context.Users.FirstOrDefaultAsync(x => x.ID == id && x.Enable);
            if (user == null)
            {
                throw new GiJoException($"El usuario '{id}' no existe o esta deshabilitado");
            }

            if (!string.Equals(resetPassword.Password, user.Password))
            {
                throw new GiJoException("Contraseña Incorrecta");
            }

            user.Password = resetPassword.NewPassword;

            await this._context.SaveChangesAsync();
            return user;
        }

        public async Task<User> LoginUser(Login login)
        {
            // Validar usuario y contraseña.
            if (string.IsNullOrWhiteSpace(login?.Username) || string.IsNullOrWhiteSpace(login?.Password))
            {
                throw new GiJoException("Usuario o Contraseña Incorrecta");
            }

            var user = await this._context.Users
                .FirstOrDefaultAsync(x => x.Enable
              && x.Username.ToLower().Equals(login.Username.ToLower())
              && x.Password == login.Password);

            if (user == null)
            {
                throw new GiJoException("Usuario o Contraseña Incorrecta");
            }
            else return user;
        }
        #endregion
    }
}