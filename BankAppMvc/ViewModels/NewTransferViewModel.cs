using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class NewTransferViewModel
    {
        public int AccountId { get; set; }
        public int AccountReceiversId { get; set; }
        public decimal Amount { get; set; }

    }
}
