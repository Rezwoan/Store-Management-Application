using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class Admin : User
    {
        public override IReadOnlyList<string> GetAllowedModules() => new[] {
        "Dashboard", "UserManagement", "RoleManagement", "CategoryManagement",
        "ProductManagement", "InventoryManagement", "SalesProcessing",
        "SalesHistory", "Reports", "Settings", "Profile"
    };
    }
}
