using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class StartPageViewModel
    {
        public int Customers { get; set; }
        public int Accounts { get; set; }
        public decimal Amount { get; set; }
    }
}
