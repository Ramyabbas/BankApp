using BankAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public int CustomerId { get; set; }
        public string Givenname { get; set; }
        public string Surename { get; set; }
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<AcccountDetails> Accounts { get; set; }

        public class AcccountDetails
        {
            public int AccountId { get; set; }
            public decimal Balance { get; set; }

        }

    }
}
