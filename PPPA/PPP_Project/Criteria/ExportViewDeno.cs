﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPP_Project.Criteria
{
    public class ExportViewDeno
    {       
        public string QAT { get; set; }
   
        public string Center { get; set; }
        
        public decimal TotalOfProbes { get; set; }

        public decimal TotalOfScenes { get; set; }

        public decimal TotalCancel { get; set; }

        public decimal TotalTicTac { get; set; }

        public decimal GrandTotal { get; set; }

        public decimal TotalProbes { get; set; }

        public decimal TotalPricingProbes { get; set; }

        public decimal TotalMasks { get; set; }

        public decimal TotalVotes { get; set; }

        public decimal TotalRepricing { get; set; }

        public decimal TotalScenes { get; set; }

        public decimal TotalSceneRecognition { get; set; }

        public decimal TotalCategoryExpert { get; set; }

        public decimal TotalCategoryExpertVoting { get; set; }

        public decimal TotalCategoryExpertHunt { get; set; }

        public string ImportedDate { get; set; }

    }
}