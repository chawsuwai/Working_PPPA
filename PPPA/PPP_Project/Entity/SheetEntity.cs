using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Sheet")]
    public class SheetEntity
    {
        //ID int NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public int ID { get; set; }

        //BranchName	varchar(50)	NOT NULL,
        [DbColumn(Name = "SheetName")]
        public string SheetName { get; set; }
        
    }
}