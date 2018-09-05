using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.CommonAttributes;
using System.Reflection;
using System.Data.SqlClient;
using PPP_Project.Common.Utility;
using PPP_Project.Common.BranchConfiguration;

namespace PPP_Project.Common.Builder
{
    public class InsertSqlBuilder<T> : ISqlBuilder<T> where T : EntityBase
    {
        QueryContext<T> mContext;

        public InsertSqlBuilder(T entity)
        {
            mContext = new QueryContext<T>()
            {
                mSQLParameters = new List<System.Data.SqlClient.SqlParameter>(),
                mEntity = entity,
                mKeyVal = new List<ColumnVaue>(),
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

                if (l_columnAttr != null)
                {
                    if (l_columnAttr.IsAuto != true) // Filter unecessary field for insert
                    {
                        mContext.mKeyVal.Add(new ColumnVaue
                        {

                            ColumnName = l_columnAttr.Name, // column name

                            Value = typeof(T).InvokeMember(typeof(T).GetProperties()[index].Name, BindingFlags.GetProperty, null, mContext.mEntity, null), // value

                            IsAutoKey = l_columnAttr.IsAuto, // attribute

                            IsDateField = l_columnAttr.IsDate, // attribute 

                            IsPrimaryKey = l_columnAttr.IsPrimary, // attribute
                        });

                    }
                }
            }
        }

        public void BuildSQLQueryString()
        {
            string l_SQL = " INSERT INTO " + mContext.Table + " (";

            for (int index = 0; index < mContext.mKeyVal.Count; index++)
            {
                l_SQL += index == 0 ? mContext.mKeyVal[index].ColumnName : "," + mContext.mKeyVal[index].ColumnName;
            }

            l_SQL += ") VALUES ( ";

            for (int index = 0; index < mContext.mKeyVal.Count; index++)
            {
                l_SQL += index == 0 ? "@" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", "")

                    : ", @" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", "");
            }

            l_SQL += ")";

            mContext.mSQL = l_SQL;
        }

        public void BuildSQLParameters()
        {
            for (int index = 0; index < mContext.mKeyVal.Count; index++)
            {
                string col = mContext.mKeyVal[index].ColumnName;

                string value = mContext.mKeyVal[index].ColumnName;

                if (mContext.mKeyVal[index].IsDateField && !string.IsNullOrWhiteSpace((string)mContext.mKeyVal[index].Value))
                {
                    mContext.mSQLParameters.Add(new SqlParameter
                    {
                        ParameterName = mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", ""),

                        Value = GeneralUtility.ConvertSystemDateStringFormat(((string)mContext.mKeyVal[index].Value).Trim())
                    });
                }
                else
                {
                mContext.mSQLParameters.Add(new SqlParameter
                {
                    ParameterName = "@" + mContext.mKeyVal[index].ColumnName.Replace("[", "").Replace("]", ""),

                    Value = mContext.mKeyVal[index].Value ?? DBNull.Value
                });
                }
            }
        }

        public QueryContext<T> GetSQLContext()
        {
            return mContext;
        }
    }
}