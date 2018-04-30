using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceCLIApp.Models
{
    class Transaction
    {
        public DateTime ExecutionTime { get; set; }
        public Decimal Amount { get; set; }
    }
}
