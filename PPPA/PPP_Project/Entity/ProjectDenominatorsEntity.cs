using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Entity
{
    [Serializable]
    [DbTable(Name = "ProjectDenominators")]
    public class ProjectDenominatorsEntity:EntityBase
    {
        //[ID] [varchar](50) NOT NULL,
        [DbColumn(Name = "ID", IsPrimary = true)]
        public string ID { get; set; }

        //[PROJECT] [varchar](50) NULL,
        [DbColumn(Name = "PROJECT")]
        public string PROJECT { get; set; }

        //[Probes] [decimal](18, 2) NULL,
        [DbColumn(Name = "Probes")]
        public decimal Probes { get; set; }

        //[Pricingprobes] [decimal](18, 2) NULL,
        [DbColumn(Name = "Pricingprobes")]
        public decimal Pricingprobes { get; set; }

        //[Masks] [decimal](18, 2) NULL,
        [DbColumn(Name = "Masks")]
        public decimal Masks { get; set; }

        //[Repricing] [decimal](18, 2) NULL,
        [DbColumn(Name = "Repricing")]
        public decimal Repricing { get; set; }

        //[SceneRecog] [decimal](18, 2) NULL,
        [DbColumn(Name = "SceneRecog")]
        public decimal SceneRecog { get; set; }

        //[ProbesperScene] [decimal](18, 2) NULL,
        [DbColumn(Name = "ProbesperScene")]
        public decimal ProbesperScene { get; set; }

        //[Expert] [decimal](18, 2) NULL,
        [DbColumn(Name = "Expert")]
        public decimal Expert { get; set; }

        //[CreatedBy] [varchar](50) NULL,
        [DbColumn(Name = "Createdby")]
        public string Createdby { get; set; }

         [DbColumn(Name = "DenoMonth")]
        public string DenoMonth { get; set; }        
    }
}