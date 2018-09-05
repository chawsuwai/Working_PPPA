using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Reflection;
using PPP_Project.CommonAttributes;

namespace PPP_Project.Common.Mapper
{
    public class SqlSelect<T> where T : new()
    {
        IDataReader mReader;

        T _type;

        public SqlSelect(IDataReader aReader)
        {
            mReader = aReader;
        }

        public List<T> GetValues()
        {
            List<T> l_Rows = new List<T>();

            Hashtable hashtable = new Hashtable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {

                DbColumnAttribute[] col_attrs = (DbColumnAttribute[])info.GetCustomAttributes(typeof(DbColumnAttribute), false);

                if (col_attrs != null && col_attrs.Length > 0)
                {

                    hashtable[col_attrs[0].Name.ToUpper().Replace("[", "").Replace("]", "")] = info;
                }
                else
                {
                    hashtable[info.Name.ToUpper().Replace("[", "").Replace("]", "")] = info;
                }
            }

            using (mReader)
            {
                while (mReader.Read())
                {
                    _type = new T();

                    for (int _index = 0; _index < mReader.FieldCount; _index++)
                    {
                        PropertyInfo info = (PropertyInfo)hashtable[mReader.GetName(_index).ToUpper()];

                        if ((info != null) && info.CanWrite)
                        {

                            var targetType = IsNullableType(info.PropertyType) ? Nullable.GetUnderlyingType(info.PropertyType)
                                : info.PropertyType;

                            var convertedValue = mReader.GetValue(_index) == DBNull.Value ? null
                                : Convert.ChangeType(mReader.GetValue(_index), targetType);

                            info.SetValue(_type, convertedValue, null);

                            //if (info.GetCustomAttributes<DbColumnAttribute>() != null
                            //    && convertedValue != null)
                            //{
                            //    if (info.GetCustomAttribute<DBColumnAttribute>().IsDate)
                            //    {
                            //        info.SetValue(_type, GeneralUtility.ConvertDisplayDateStringFormat((string)convertedValue), null);
                            //    }
                            //}
                        }
                    }
                    l_Rows.Add(_type);
                }
            }
            return l_Rows;
        }

        private static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>));
        }
    }
}