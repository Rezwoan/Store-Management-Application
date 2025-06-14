using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastPasswordSet { get; set; }
        public string RoleName { get; set; }

        // Returns module identifiers for UI navigation
        public abstract IReadOnlyList<string> GetAllowedModules();
    }
}
