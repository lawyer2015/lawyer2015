using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using lawyer2015.Models;

namespace lawyer2015.Models.Database
{
    public class ProviderDegree : CoreTableName
    {
        [InverseProperty("ProviderDegree")]
        public virtual ICollection<UserProviderDegree> UserProviderDegrees { get; set; }
    }
}