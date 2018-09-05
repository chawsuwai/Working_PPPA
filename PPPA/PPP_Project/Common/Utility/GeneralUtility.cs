using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace PPP_Project.Common.Utility
{
    public class GeneralUtility
    {
        #region methods

        public static string ConvertSystemDateStringFormat(string aDate)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(aDate))
                {
                    if (aDate.Length == 8)
                    {
                        int i = 0;
                        if (int.TryParse(aDate, out i))
                        {
                            return aDate;
                        }
                    }

                    if (aDate.Length != 10)
                    {
                        throw new Exception("Date format is incorrect");
                    }

                    if (aDate.Contains('/'))
                    {
                        string[] l_strDate = aDate.Split('/');
                        int l_TryPass1 = int.Parse(l_strDate[2]);
                        int l_TryPass2 = int.Parse(l_strDate[0]);
                        int l_TryPass3 = int.Parse(l_strDate[1]);

                        string l_Date = l_strDate[2] + l_strDate[1] + l_strDate[0];
                        return l_Date;
                    }
                    else
                    {
                        return aDate;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static string ConvertMonthYearStringFormat(string aDate)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(aDate))
                {
                    if (aDate.Length == 6)
                    {
                        int i = 0;
                        if (int.TryParse(aDate, out i))
                        {
                            return aDate;
                        }
                    }

                    if (aDate.Length != 7)
                    {
                        throw new Exception("Date format is incorrect");
                    }

                    if (aDate.Contains('/'))
                    {
                        string[] l_strDate = aDate.Split('/');
                        int l_TryPass1 = int.Parse(l_strDate[0]);
                        int l_TryPass2 = int.Parse(l_strDate[1]);                  

                        string l_Date =  l_strDate[1] + l_strDate[0];
                        return l_Date;
                    }
                    else
                    {
                        return aDate;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static string ConvertSystemDateStringFormat(DateTime? aDate)
        {
            try
            {
                if (aDate.HasValue)
                {
                    #region convert date to string format

                    int l_Year = aDate.Value.Year;
                    int l_month = aDate.Value.Month;
                    int l_day = aDate.Value.Day;

                    string l_strYear = l_Year.ToString();
                    string l_strMonth = l_month.ToString("00");
                    string l_strDay = l_day.ToString("00");
                    return l_strYear + l_strMonth + l_strDay;

                    #endregion
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {

                return string.Empty;
            }
        }

        public static string ConvertDisplayDateStringFormat(string aDate)
        {
            try
            {
                if (aDate.Length == 0)
                {
                    return "";
                }
                Regex l_reg = new Regex(RegEx.DMY);

                Match l_match = l_reg.Match(aDate);

                if (l_match.Success)
                {
                    return aDate;
                }
                else
                {
                    string l_year = aDate.Substring(0, 4);
                    string l_month = aDate.Substring(4, 2);
                    string l_day = aDate.Substring(6, 2);
                    return l_day + "/" + l_month + "/" + l_year;
                }
            }
            catch
            {

                return string.Empty;
            }
        }

        public static string ConvertDisplayDateStringFormat(DateTime? aDate)
        {
            try
            {
                int l_Year = aDate.Value.Year;
                int l_month = aDate.Value.Month; ;
                int l_day = aDate.Value.Day;
                string l_strMonth;
                string l_strDay;
                if (l_month < 10)
                {
                    l_strMonth = "0" + l_month;
                }
                else
                {
                    l_strMonth = l_month.ToString();
                }
                if (l_day < 10)
                {
                    l_strDay = "0" + l_day;
                }
                else
                {
                    l_strDay = l_day.ToString();
                }
                return l_strDay + "/" + l_strMonth + "/" + l_Year;
            }
            catch
            {

                return string.Empty;
            }
        }


        public static string ConvertDisplayTimeFormat(string aTime)
        {
            try
            {
                if (aTime.Length == 0)
                {
                    return string.Empty;
                }

                string l_Hour = aTime.Substring(0, 2);
                string l_Min = aTime.Substring(2, 2);
                //   string l_Sec = aTime.Substring(4, 2);

                return string.Format("{0}:{1}", l_Hour, l_Min);
            }
            catch
            {

                return string.Empty;
            }
        }

        public static DateTime? ConvertDateFormat(string aDateString)
        {
            try
            {
                if (string.IsNullOrEmpty(aDateString))
                {
                    return null;
                }

                int l_year = Convert.ToInt32(aDateString.Substring(0, 4));

                int l_month = Convert.ToInt32(aDateString.Substring(4, 2));

                int l_day = Convert.ToInt32(aDateString.Substring(6, 2));

                DateTime l_date = new DateTime(l_year, l_month, l_day);

                return l_date.Date;
            }
            catch
            {
                return null;
            }
        }

        public static void SetProjectDateFormat(string aFormat, string aSeperator)
        {
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);

            ci.DateTimeFormat.ShortDatePattern = aFormat;

            ci.DateTimeFormat.DateSeparator = aSeperator;

            Thread.CurrentThread.CurrentCulture = ci;
        }

        public static string ConvertSystemTimeFormat(DateTime aDate)
        {
            string l_Time = "";

            l_Time += aDate.Hour.ToString("00");

            l_Time += aDate.Minute.ToString("00");

            l_Time += aDate.Second.ToString("00");

            return l_Time;
        }

        public static string ServerDate
        {
            get
            {
                return ConvertSystemDateStringFormat(System.DateTime.Now);
            }
        }

        public static string ServerTime
        {
            get { return ConvertSystemTimeFormat(System.DateTime.Now); }
        }

        public static string GeneratedKey
        {
            get
            {
                Thread.Sleep(100);

                DateTime l_CurrentDate = System.DateTime.Now;

                return GeneralUtility.ConvertSystemDateStringFormat(l_CurrentDate)

                    + GeneralUtility.ConvertSystemTimeFormat(l_CurrentDate)

                    + l_CurrentDate.Millisecond.ToString("0000");


            }
        }

        public static class RegEx
        {
            public const string DMY = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";
        }

        public static string GenerateAccountCode(string firstCode, string secondCode, string thirdCode)
        {
            return firstCode + ConcactCode(secondCode) + ConcactCode(thirdCode);
        }

        private static string ConcactCode(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                return "." + code;
            }
            else
            {
                return "";
            }

        }

        public static string ConvertDisplayMonthStringFormat(string aDate)
        {
            try
            {
                if (aDate.Length == 0)
                {
                    return "";
                }
                Regex l_reg = new Regex(RegEx.DMY);

                Match l_match = l_reg.Match(aDate);

                if (l_match.Success)
                {
                    return aDate;
                }
                else
                {
                    string l_year = aDate.Substring(0, 4);
                    string l_month = aDate.Substring(4, 2);
                    //string l_day = aDate.Substring(6, 2);
                    return  l_month + "/" + l_year;
                }
            }
            catch
            {

                return string.Empty;
            }
        }

        #endregion
    }
}