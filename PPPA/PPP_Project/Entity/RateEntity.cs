using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Rate")]
    public class RateEntity : EntityBase
    {      
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //QAT	varchar(50)	NOT NULL,
        [DbColumn(Name = "Rate1")]
        public Decimal Rate1 { get; set; }

        [DbColumn(Name = "Rate2")]
        public Decimal Rate2 { get; set; }

        [DbColumn(Name = "Rate3")]
        public Decimal Rate3 { get; set; }

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

        [DbColumn(Name = "UpdatedBy")]
        public string UpdatedBy { get; set; }

        [DbColumn(Name = "UpdatedDate")]
        public string UpdatedDate { get; set; }

        [DbColumn(Name = "RatedYear")]
        public string RatedYear { get; set; }
        
      
    }
}