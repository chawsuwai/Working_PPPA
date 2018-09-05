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
    [DbTable(Name = "Accuracy")]
    public class AccuracyEntity : EntityBase
    {
        //[ID] [varchar](50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //QAT	varchar(50)	NOT NULL,
        [DbColumn(Name = "QAT")]
        public string QAT { get; set; }

        [DbColumn(Name = "Center")]
        public string Center { get; set; }

        [DbColumn(Name = "AccuracyPercent")]
        public decimal AccuracyPercent { get; set; }

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

        [DbColumn(Name = "AccMonth")]
        public string AccMonth { get; set; }
    }
}