using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using System.Data.SqlClient;
using PPP_Project.CommonAttributes;
using System.Reflection;

namespace PPP_Project.Common.Builder
{
    public class DeleteBuilder<T>:ISqlBuilder<T> where T:EntityBase 
    {
        QueryContext<T> Context;

        public DeleteBuilder(T aEntity)
        {
            Context = new QueryContext<T>
            {
                mSQLParameters = new List<SqlParameter>(),

                mKeyVal = new List<ColumnVaue>(),

                mEntity = aEntity,
            };
        }

        public void SetTableName()
        {
            if (string.IsNullOrWhiteSpace(Context.mEntity.TableName))
            {
                foreach (DbTableAttribute att in typeof(T).GetCustomAttributes(typeof(DbTableAttribute), false))
                {
                    Context.Table = att.Name;
                }
            }
            else
            {
                Context.Table = Context.mEntity.TableName;
            }
        }

        public void BuildLogicalPhyisical()
        {
            for (int index = 0; index < typeof(T).GetProperties().Count(); index++)
            {
                DbColumnAttribute l_columnAttr = null;

                foreach (DbColumnAttribute attr in typeof(T).GetProperties()[index].GetCustomAttributes(typeof(DbColumnAttribute), false))
                {
                    l_columnAttr = attr;
                }
                if (l_columnAttr != null)
                {
                    if (l_columnAttr.Name == "ID")
                    {
                        Context.mKeyVal.Add(new ColumnVaue
                        {
                            ColumnName = l_columnAttr.Name,

                            Value = typeof(T).InvokeMember(typeof(T).GetProperties()[index].Name, BindingFlags.GetProperty, null, Context.mEntity, null),

                            IsAutoKey = l_columnAttr.IsAuto,

                            IsDateField = l_columnAttr.IsDate,

                            IsPrimaryKey = l_columnAttr.IsPrimary,
                        });
                    }
                }
            }
        }

        public void BuildSQLQueryString()
        {
            Context.mSQL = " DELETE FROM " + Context.Table + " WHERE ID = @ID";
        }

        public void BuildSQLParameters()
        {
            for (int index = 0; index < Context.mKeyVal.Count; index++)
            {
                if (Context.mKeyVal[index].ColumnName == "ID")
                {
                    Context.mSQLParameters.Add(new SqlParameter { ParameterName = "@" + Context.mKeyVal[index].ColumnName, Value = Context.mKeyVal[index].Value });
                }
            }
        }

        public QueryContext<T> GetSQLContext()
        {
            return Context;
        }
    }
}