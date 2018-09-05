using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PPP_Project.Common.Builder
{
    public class QueryContext<T>
    {
        public string Table;

        public T mEntity;

        public List<ColumnVaue> mKeyVal;

        public string mSQL;

        public List<SqlParameter> mSQLParameters;
    }
    public class ColumnVaue
    {
        public string ColumnName { get; set; }

        public object Value { get; set; }

        public bool IsAutoKey { get; set; }

        public bool IsPrimaryKey { get; set; }

        public bool IsDateField { get; set; }

        public bool IsRefrence { get; set; }
    }
}