using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using PPP_Project.Common.Mapper;

namespace PPP_Project.Common.Feature
{
    public class DBReader<E> : IDBReadable<E> where E : EntityBase, new()
    {
        #region implements

        /// <summary>
        /// To Excute SQL Select Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="con"></param>
        /// <returns></returns>
        public List<B> ExcuteStoreQuery<B>(string aSQL, List<DbParameter> aPrams, string con, CommandType aCommendType = CommandType.Text) where B : new()
        {
            List<B> l_Rows = new List<B>();

            SqlConnection l_Connection = new SqlConnection(con);

            SqlCommand l_Command = new SqlCommand();

            l_Command.Connection = l_Connection;

            l_Command.CommandType = aCommendType;

            l_Command.CommandTimeout = 0;

            l_Command.CommandText = aSQL;

            if (aPrams != null)
            {
                foreach (SqlParameter l_params in aPrams)
                {
                    l_Command.Parameters.Add(l_params);
                }
            }
            try
            {
                l_Connection.Open();

                SqlDataReader l_Reader = l_Command.ExecuteReader();

                l_Rows = new SqlSelect<B>(l_Reader).GetValues();

                return l_Rows;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                l_Connection.Close();
            }
        }

        /// <summary>
        /// To Excute SQL Select Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="aDAOConnection"></param>
        /// <returns></returns>
        public List<B> ExcuteStoreQuery<B>(string aSQL, List<DbParameter> aPrams, string con) where B : new()
        {
            try
            {
                return ExcuteStoreQuery<B>(aSQL, aPrams, con, CommandType.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        ///To Excute SQL Excute Scalar
        /// </summary>
        /// <param name="aSQL"></param>
        /// <param name="aPrams"></param>
        /// <param name="aDatabase"></param>
        /// <returns></returns>
        public object ExcuteScalar(string aSQL, List<DbParameter> aPrams, string con)
        {
            object l_Result;

            SqlConnection l_Connection = new SqlConnection(con);

            SqlCommand l_Command = new SqlCommand();

            l_Command.Connection = l_Connection;

            l_Command.CommandText = aSQL;

            if (aPrams != null)
            {
                foreach (SqlParameter l_commend in aPrams)
                {
                    l_Command.Parameters.Add(l_commend);
                }
            }
            try
            {
                l_Connection.Open();

                l_Result = l_Command.ExecuteScalar();

                return l_Result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                l_Connection.Close();
            }
        }

        /// <summary>
        ///To Excute SQL Excute Non Query
        /// </summary>
        /// <param name="aSQL"></param>
        /// <param name="aParams"></param>
        /// <param name="aDatabase"></param>
        public void ExcuteNonQuery(string aSQL, List<DbParameter> aParams, string con)
        {
            //string l_syskey = GeneralUtility.GeneratedKey;

            SqlConnection l_Connection = new SqlConnection(con);

            SqlCommand l_Command = new SqlCommand();

            l_Command.Connection = l_Connection;

            l_Command.CommandText = aSQL;

            if (aParams != null)
            {
                foreach (var v in aParams)
                {
                    l_Command.Parameters.Add(v);
                }
            }

            try
            {
                l_Connection.Open();

                l_Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                l_Connection.Close();
            }
        }

        #endregion

    }
}