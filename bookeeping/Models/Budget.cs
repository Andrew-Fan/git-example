using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bookeeping.Models
{
    public class Budget
    {
        [Key]
        public int BudgetID{ get; set; }
        public int UserID{ get; set; }

        public DateTime Period{ get; set; }

        public decimal Food{ get; set; }
        public decimal Transport{ get; set; }
        public decimal Entertainment{ get; set; }
        public decimal Shopping{ get; set; }
        public decimal Personal{ get; set; }
        public decimal Learning{ get; set; }
        public decimal Other{ get; set; }

        public ApplicationUser Users{ get; set; }
    }
}