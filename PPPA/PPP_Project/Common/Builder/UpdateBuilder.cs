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
    public class UpdateSQLBuilder<T> : ISqlBuilder<T> where T : EntityBase
    {
        #region implement
        QueryContext<T> mContext;

        public UpdateSQLBuilder(T Entity)
        {
            mContext = new QueryContext<T>
            {
                mSQLParameters = new List<SqlParameter>(),

                mKeyVal = new List<ColumnVaue>(),

                mEntity = Entity,

            };
        }

        public void SetTableName()
        {
            if (string.IsNullOrWhiteSpace(mContext.mEntity.TableName))
            {
                foreach (DbTableAttribute att in typeof(T).GetCustomAttributes(typeof(DbTableAttribute), false))
                {
                    mContext.Table = att.Name;
                }
            }
            else
            {
                mContext.Table = mContext.mEntity.TableName;
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
                if (l_columnAttr != null )
                {
                    if (l_columnAttr.Name != "CreatedDate"
                        && l_columnAttr.IsAuto != true
                        )
                    {
                        mContext.mKeyVal.Add(new ColumnVaue
                        {
                            ColumnName = l_columnAttr.Name,

                            Value = typeof(T).InvokeMember(typeof(T).GetProperties()[index].Name, BindingFlags.GetProperty, null, mContext.mEntity, null),

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
            string l_SQL = " UPDATE " + mContext.Table + " SET ";

            for (int index = 0; index < mContext.mKeyVal.Count; index++)
            {

                l_SQL += index == 0 ? mContext.mKeyVal[index].ColumnName + "=@" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", "")

                    : "," + mContext.mKeyVal[index].ColumnName + "=@" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", "");
            }

            //l_SQL += " WHERE " + mContext.mKeyVal[0].ColumnName + " =@" + mContext.mKeyVal[0].ColumnName.Replace("[", "").Replace("]", "");

            l_SQL += GetPrimaryKey();

            mContext.mSQL = l_SQL;
        }

        public void BuildSQLParameters()
        {
            for (int index = 0; index < mContext.mKeyVal.Count; index++)
            {
                string col = mContext.mKeyVal[index].ColumnName;

                string value = mContext.mKeyVal[index].ColumnName;

                    mContext.mSQLParameters.Add(new SqlParameter
                    {
                        ParameterName = "@" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", ""),

                        Value = mContext.mKeyVal[index].Value ?? DBNull.Value
                    });
                
            }
        }

        public QueryContext<T> GetSQLContext()
        {
            return mContext;
        }

        private string GetPrimaryKey()
        {
            var query = "";
            for (int index = 0; index < typeof(T).GetProperties().Count(); index++)
            {
                DbColumnAttribute l_columnAttr = null;
                foreach (DbColumnAttribute attr in typeof(T).GetProperties()[index].GetCustomAttributes(typeof(DbColumnAttribute), false))
                {
                    l_columnAttr = attr;
                }
                if (l_columnAttr != null)
                {
                    if (l_columnAttr.IsPrimary == true)
                    {
                        if (l_columnAttr.IsAuto)
                        {
                            query += " WHERE " + l_columnAttr.Name + " =" + typeof(T).InvokeMember(typeof(T).GetProperties()[index].Name, BindingFlags.GetProperty, null, mContext.mEntity, null);
                        }
                        else
                        {
                            query += " WHERE " + l_columnAttr.Name + " =@" + l_columnAttr.Name;
                        }
                    }
                }
            }
            return query;
            
        }
        #endregion
    }
}