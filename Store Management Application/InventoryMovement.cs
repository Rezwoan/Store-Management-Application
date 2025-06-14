using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class InventoryMovement
    {
        public int MovementId { get; set; }
        public int ProductId { get; set; }
        public int QuantityChange { get; set; }
        public string MovementType { get; set; }
        public string Remarks { get; set; }
        public int PerformedBy { get; set; }
        public DateTime PerformedAt { get; set; }

        // Optional navigation
        public Product Product { get; set; }
        public User PerformedUser { get; set; }
    }
}
