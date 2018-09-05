using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "QAT")]
    public class QATEntity : EntityBase
    {
        //[ID] [varchar](50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //[QAT] [varchar](50) NULL,
        [DbColumn(Name = "QAT")]
        public string QAT { get; set; }

        [DbColumn(Name = "Center")]
        public string Center { get; set; }

        //[Expert] [decimal](18, 2) NULL,
        [DbColumn(Name = "Name")]
        public string Name { get; set; }

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

        [DbColumn(Name = "Month")]
        public string Month { get; set; }
    }
}