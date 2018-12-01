using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using lawyer2015.Models;

namespace lawyer2015.Models.Database
{
    public class CoreTableName : CoreTableID
    {
        [Required]
        [Column("Name", TypeName = "nvarchar")]
        [MaxLength(50)]
        public virtual string Name { get; set; }
    }
}