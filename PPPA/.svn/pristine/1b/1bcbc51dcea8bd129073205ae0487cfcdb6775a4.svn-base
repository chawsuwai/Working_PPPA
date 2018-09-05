using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "DenoChange")]
    public class DenoChangeEntity : EntityBase
    {
        //[ID] [varchar](50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //[PROJECT] [varchar](50) NULL,
        [DbColumn(Name = "PROJECT")]
        public string PROJECT { get; set; }

        //[Probes] [decimal](18, 2) NULL,
        [DbColumn(Name = "Probes")]
        public System.Nullable<Decimal> Probes { get; set; }

        //[Pricingprobes] [decimal](18, 2) NULL,
        [DbColumn(Name = "Pricingprobes")]
        public System.Nullable<Decimal> Pricingprobes { get; set; }

        //[Votes] [decimal](18, 2) NULL,
        [DbColumn(Name = "Votes")]
        public System.Nullable<Decimal> Votes { get; set; }

        //[Masks] [decimal](18, 2) NULL,
        [DbColumn(Name = "Masks")]
        public System.Nullable<Decimal> Masks { get; set; }

        //[Repricing] [decimal](18, 2) NULL,
        [DbColumn(Name = "Repricing")]
        public System.Nullable<Decimal> Repricing { get; set; }

        //[SceneRecog] [decimal](18, 2) NULL,
        [DbColumn(Name = "SceneRecog")]
        public System.Nullable<Decimal> SceneRecog { get; set; }

        //[ProbesperScene] [decimal](18, 2) NULL,
        [DbColumn(Name = "ProbesperScene")]
        public System.Nullable<Decimal> ProbesperScene { get; set; }

        //[Expert] [decimal](18, 2) NULL,
        [DbColumn(Name = "Expert")]
        public System.Nullable<Decimal> Expert { get; set; }

        //[ExpertVoting] [decimal](18, 2) NULL,
        [DbColumn(Name = "ExpertVoting")]
        public System.Nullable<Decimal> ExpertVoting { get; set; }

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

        [DbColumn(Name = "DCDate")]
        public string DCDate { get; set; }       

        [DbColumn(Name = "UpdatedBy")]
        public string UpdatedBy { get; set; }

        [DbColumn(Name = "UpdatedDate")]
        public string UpdatedDate { get; set; }
    }
}