using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Management_Application
{
    public class CompanyInfo
    {
        public int CompanyInfoId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LogoPath { get; set; }
        public decimal TaxRate { get; set; }
    }
}
