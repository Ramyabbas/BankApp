using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.ViewModels
{
    public class CustomerIndexViewModel
    {
        public string q { get; set; }
        public List<CustomersViewModel> customers { get; set; }
        public string sortOrder { get; set; }
        public string sortField { get; set; }
        public string OppositeSortOrder { get; set; }
        public int Page { get; set; }
        public int TotalPages { get; set; }
        public int AccountId { get; set; }
        public class CustomersViewModel
        {
            public int CustomerId { get; set; }
            public string Givenname { get; set; }
            public string Surename { get; set; }
            public string StreetAdress { get; set; }
            public string City { get; set; }
            public string Country { get; set; }

        }

    }
}
