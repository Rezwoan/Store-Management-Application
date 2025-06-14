using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class AuditLog
    {
        public int LogId { get; set; }
        public DateTime PerformedAt { get; set; }
        public int? PerformedBy { get; set; }
        public string Entity { get; set; }
        public int? EntityId { get; set; }
        public string Action { get; set; }
        public string Details { get; set; }
    }
}
