using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models.Models
{
    public class LoanCreated
    {
        public string LoanNumber { get; set; }
        public DateTime LoanCreationDate { get; set; }
        public string LoanType { get; set; }
        public decimal LoanAmount { get; set; }
    }
}
