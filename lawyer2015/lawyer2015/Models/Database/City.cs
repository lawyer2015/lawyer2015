using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using lawyer2015.Models;

namespace lawyer2015.Models.Database
{
    [Table("City")]
    public class City : CoreTableName
    {
        [InverseProperty("City")]
        public virtual ICollection<Address> Addresses { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Request> Requests { get; set; }
    }
}