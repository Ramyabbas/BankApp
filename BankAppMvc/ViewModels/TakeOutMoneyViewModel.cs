using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class TakeOutMoneyViewModel
    {
        public int AccountId { get; set; }
        public decimal Amount { get; set; }

    }
}
