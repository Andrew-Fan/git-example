using System;
using System.Security.Authentication;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using bookeeping.Models;

namespace bookeeping.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public decimal Balance{ get; set; }

        public ICollection<Budget> Budgets{ get; set;}
        public ICollection<Journal> Journals{ get; set; }
    }
}