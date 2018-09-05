using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;

namespace PPP_Project.Common.Builder
{
    public class QueryDirector<T> where T : EntityBase
    {
        ISqlBuilder<T> SqlMapper;

        public QueryDirector(ISqlBuilder<T> SQLBuilder)
        {
            SqlMapper = SQLBuilder;

            SqlMapper.SetTableName();

            SqlMapper.BuildLogicalPhyisical();

            SqlMapper.BuildSQLQueryString();

            SqlMapper.BuildSQLParameters();
        }

        public QueryContext<T> GetDataContext()
        {
            return SqlMapper.GetSQLContext();
        }
    }
}