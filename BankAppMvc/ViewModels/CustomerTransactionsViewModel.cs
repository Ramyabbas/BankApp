using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class CustomerTransactionsViewModel
    {
        public List<TransactionsRowViewModel> Transactions { get; set; }
    }

    
    public class TransactionsRowViewModel
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Operation { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
    }
    public class TransactionsGetFromViewModel
    {
        public List<TransactionsRowViewModel> Transactions { get; set; }

    }
}
