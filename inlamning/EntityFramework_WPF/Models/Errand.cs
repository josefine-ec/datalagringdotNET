using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Models
{
    internal class Errand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ErrandName { get; set; } = null!;

        [Required]
        [StringLength(150)]
        public string Description { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;

        public DateTime DateTime { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
