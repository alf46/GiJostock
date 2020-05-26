using DataModel.Repositories;
using System.Runtime.Serialization;

namespace DataModel
{
    public class User : IDisable
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Privilege { get; set; }
        public bool Enable { get; set; } = true;
    }
}