using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPP_Project.Common.Extension
{
    public static class CommaExtension
    {
        public static string AddComma(this string name)
        {
            return name+",";

        }
    }
}