using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;

namespace PPP_Project.Common.BranchConfiguration
{
    public sealed class BranchSection : ConfigurationSection
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }
         
        private static BranchSection instance = null;

        public static BranchSection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = (BranchSection)WebConfigurationManager
                         .GetSection("BranchConfig");
                }
                return instance;
            }
        }
    }
}