using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPP_Project.CommonAttributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class DbColumnAttribute : Attribute
    {
        public string Name { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsAuto { get; set; }
        public bool IsDate { get; set; }
        public bool IsRefrence { get; set; }

        public DbColumnAttribute()
        {
            Name = "gggg";
            IsAuto = false;
            IsPrimary = false;
            IsDate = false;
            IsRefrence = false;
        }
    }
}