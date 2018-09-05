using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPP_Project.Common.Builder
{
    public interface ISqlBuilder<T>
    {
        void SetTableName();

        void BuildLogicalPhyisical();

        void BuildSQLQueryString();

        void BuildSQLParameters();

        QueryContext<T> GetSQLContext();
    }
}
