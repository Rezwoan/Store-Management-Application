using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class Manager : User
    {
        public override IReadOnlyList<string> GetAllowedModules() => new[] {
        "Dashboard", "CategoryManagement", "ProductManagement",
        "InventoryManagement", "SalesProcessing", "SalesHistory",
        "Reports", "Profile"
    };
    }
}
