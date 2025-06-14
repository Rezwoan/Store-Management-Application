using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class Salesman : User
    {
        public override IReadOnlyList<string> GetAllowedModules() => new[] {
        "Dashboard", "SalesProcessing", "MySalesHistory", "Profile"
    };
    }
}
