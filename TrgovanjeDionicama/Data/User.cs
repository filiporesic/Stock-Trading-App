using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovanjeDionicama
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastUpdatedAtUTC { get; set; }

        public User(string username, string email, string firstName, string lastName, string password)
        {
            Username = username;
            Email = email; 
            FirstName = firstName; 
            LastName = lastName;
            PasswordHash = PasswordManager.ComputeSha256Hash(password);
            LastUpdatedAtUTC = DateTime.UtcNow;
        }

        public User() { }
    }
}
