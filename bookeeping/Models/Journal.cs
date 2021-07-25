using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookeeping.Models
{
    public class Journal
    {
        [Key]
        public int JournalID{ get; set; }
        [ForeignKey("ApplicationUser")]
        public int UserID{ get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Date{ get; set; }
        [Required]
        public int Type{ get; set; } //0:收入 1:支出
        [Required]
        public string Category{ get; set; }

        [Required]
        public string AccountingTitle{ get; set; }
        [MaxLength(150)]
        public string Description{ get; set; }
        [Required]
        public decimal Amount{ get; set; }
        
        public ApplicationUser Users{ get; set; }
    }

    enum category
    {
        Food = 1,
        Transport = 2,
        Entertainment = 3,
        Shopping = 4,
        Personal = 5,
        Learning = 6,
        Other = 7
    }
}