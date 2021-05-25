using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankAppMvc.Models
{
    public class PermenentOrder
    {

        [Key]
        [Required]
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public string BankTo { get; set; }
        public string AccountTo { get; set; }
        public decimal Amount { get; set; }
        public string Symbol { get; set; }
    }
}
