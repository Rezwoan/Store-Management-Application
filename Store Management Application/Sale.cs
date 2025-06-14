using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int SoldBy { get; set; }
        public decimal Subtotal { get; set; }
        public decimal VATTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public string PaymentType { get; set; }

        // Loaded via SalesService
        public IReadOnlyList<SaleItem> Items { get; set; }
    }
}
