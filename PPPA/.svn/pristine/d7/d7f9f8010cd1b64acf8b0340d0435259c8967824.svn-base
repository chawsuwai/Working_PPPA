using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "ProjectNames")]
    public class ProjectNamesEntity : EntityBase
    {
        //[ID] [varchar](50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //[PROJECT] [varchar](50) NULL,
        [DbColumn(Name = "PROJECT")]
        public string PROJECT { get; set; }

        [DbColumn(Name = "Sheet")]
        public string Sheet { get; set; }

        [DbColumn(Name = "Status")]
        public string Status { get; set; }      

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

        [DbColumn(Name = "ImportMonth")]
        public string ImportMonth { get; set; }      


    }
}