using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPP_Project.Criteria
{
    public class ExportAccuracy
    {
        public string QAT { get; set; }

        public string Name { get; set; }

        public decimal TotalProbes { get; set; }

        public string Quality { get; set; }

        public string AmountforAccuracy { get; set; }

        public decimal AmountforProbes { get; set; }

        public decimal PPPA { get; set; }            

        public string Month { get; set; }

        public string Center { get; set; }

        public decimal RQuality { get; set; }   

    }
}