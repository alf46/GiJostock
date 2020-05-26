using System.Linq;

namespace GiJoStock
{
    public class User : BaseEntity, IDisable
    {
        public int ID { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Privilege { get; set; }

        public override string ToString()
        {
            return this.Username;
        }

        public bool HasPrivilege(Privilege privilege)
        {
            var privileges = this.Privilege.Split(',').ToList();
            var privilegeStr = ((int)privilege).ToString();
            return privileges.Contains(privilegeStr);
        }
    }
}