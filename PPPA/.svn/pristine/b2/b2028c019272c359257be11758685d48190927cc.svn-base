using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "Branch")]
    public class BranchEntity
    {
        //ID int NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true )]
        public int ID { get; set; }

        //BranchName	varchar(50)	NOT NULL,
        [DbColumn(Name = "BranchName")]
        public string BranchName { get; set; }

        //BranchCode	varchar(50)	NOT NULL,
        [DbColumn(Name = "BranchCode")]
        public string BranchCode { get; set; }
                
        [DbColumn(Name = "Address")]
        public string Address { get; set; }
    }
}