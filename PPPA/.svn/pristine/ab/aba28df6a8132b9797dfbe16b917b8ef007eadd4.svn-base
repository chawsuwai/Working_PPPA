using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using PPP_Project.Common.Enum;

namespace PPP_Project.Common.Extension
{
    public static class DAOConnection
    {
        
        public static string ToConnectionString(this ConnectionDAO val)
        {
            switch (val)
            {
                case ConnectionDAO.Server:
                    return ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
                   

                case ConnectionDAO.Client:
                    return ConfigurationManager.ConnectionStrings["Client"].ConnectionString;
                   
            }
            return ConfigurationManager.ConnectionStrings["Client"].ConnectionString;
        }
    }
}