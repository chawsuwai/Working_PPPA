using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [DbTable(Name = "Range")]
    public class ProbesRangeEntity : EntityBase
    {
       
        [DbColumn(Name = "ID", IsPrimary = true)]
        public int ID { get; set; }

        [DbColumn(Name = "Range")]
        public string Range { get; set; }

        [DbColumn(Name = "FromRange")]
        public int FromRange { get; set; }

        [DbColumn(Name = "ToRange")]
        public int ToRange { get; set; }
      
    }
}