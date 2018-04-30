using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceCLIApp.Models
{
    class TransactionsInformationModel
    {
        public decimal TotalTransactionsAmount { get; set; }
        public decimal MeanTransactionAmount { get; set; }
        public decimal LargestTransactionAmount { get; set; }
    }
}
