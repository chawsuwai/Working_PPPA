using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "ProbesQuantity")]
    public class PQuantityEntity : EntityBase
    {
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        [DbColumn(Name = "Qty")]
        public int Qty { get; set; }

        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }


    }
}