using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class Product
    {
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public decimal VATRate { get; set; }
        public int ReorderLevel { get; set; }
        public int StockQty { get; set; }

        // Optional: lazy-loaded
        public Category Category { get; set; }
    }
}
