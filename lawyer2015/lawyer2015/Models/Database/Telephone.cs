using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using lawyer2015.Models;

namespace lawyer2015.Models.Database
{
    [Table("Telephone")]
    public class Telephone : CoreTableID
    {
        [Required]
        [Column("UserId")]
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("User")]
        public virtual ApplicationUser User { get; set; }
        [Required]
        [Column("Phone", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Phone { get; set; }
    }
}