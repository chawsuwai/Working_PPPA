using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using PPP_Project.Base;

namespace PPP_Project.Common.Feature
{
    public interface IDBReadable<E> where E : DbTableBase, new()
    {

        /// <summary>
        /// To Excute SQL Select Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="aDatabase"></param>
        /// <returns></returns>
        List<B> ExcuteStoreQuery<B>(string aSQL, List<DbParameter> aPrams, string con, CommandType aCommendType = CommandType.Text) where B : new();

        /// <summary>
        /// To Excute SQL Select Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="aDAOConnection"></param>
        /// <returns></returns>
        List<B> ExcuteStoreQuery<B>(string aSQL, List<DbParameter> aPrams, string con) where B : new();

        /// <summary>
        ///To Excute SQL Excute Scalar
        /// </summary>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="aDatabase"></param>
        /// <returns></returns>
        object ExcuteScalar(string aSQL, List<DbParameter> aPrams, string con);

        /// <summary>
        ///To Excute SQL Excute Non Query
        /// </summary>
        /// <param name="aSQL"></param>
        /// <param name="aParams"></param>
        /// <param name="aDatabase"></param>
        void ExcuteNonQuery(string aSQL, List<DbParameter> aParams, string con);
    }
}
