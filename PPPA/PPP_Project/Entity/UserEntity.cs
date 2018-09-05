using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [DbTable(Name = "LoginUser")]
    public class UserEntity:EntityBase
    {
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        [DbColumn(Name = "UserType")]
        public int UserType { get; set; }

        [DbColumn(Name = "BranchCode")]
        public string BranchCode { get; set; }

        [DbColumn(Name = "Password")]
        public string Password { get; set; }

        [DbColumn(Name = "CreatedBy")]
        public string CreatedBy { get; set; }
    }
}