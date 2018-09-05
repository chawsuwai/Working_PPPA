using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [DbTable(Name = "TicTac")]
    public class TicTacEntity : EntityBase
    {
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }
        
        [DbColumn(Name = "QAT")]
        public string QAT { get; set; }
       
        [DbColumn(Name = "Center")]
        public string Center { get; set; }

        [DbColumn(Name = "Project")]
        public string Project { get; set; }

        [DbColumn(Name = "Qty")]
        public int Qty { get; set; }  

        [DbColumn(Name = "CreatedBy")]
        public string CreatedBy { get; set; }

        [DbColumn(Name = "TicTacDate")]
        public string TicTacDate { get; set; }

        [DbColumn(Name = "TicTacYear")]
        public string TicTacYear { get; set; }
    }
}