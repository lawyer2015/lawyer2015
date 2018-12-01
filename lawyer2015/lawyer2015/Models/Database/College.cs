using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
using lawyer2015.Models;

namespace lawyer2015.Models.Database
{
    [Table("College")]
    public class College : CoreTableName
    {
        [InverseProperty("College")]
        public virtual ICollection<EducationalQualification> EducationalQualifications { get; set; }
    }
}