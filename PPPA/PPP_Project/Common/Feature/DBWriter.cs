﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using System.Data.SqlClient;
using PPP_Project.Common.Builder;
using PPP_Project.Common.Utility;

namespace PPP_Project.Common.Feature
{
    public class DBWriter : IDBWriteable
    {

        #region implements

        public void ExcuteInsertCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {
            aEntity.CreatedDate =GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);

            SqlConnection l_Connection = new SqlConnection(con);

            SqlCommand l_Command = new SqlCommand(); 

            l_Command.Connection = l_Connection;

            var l_InsertQuery = new InsertSqlBuilder<B>(aEntity);

            QueryDirector<B> l_Construct = new QueryDirector<B>(l_InsertQuery);

            var l_Context = l_Construct.GetDataContext();

            l_Command.CommandTimeout = 0; 
            

            l_Command.CommandText = l_Context.mSQL;

            foreach (var l_SQLParameters in l_Context.mSQLParameters)
            {
                l_Command.Parameters.Add(l_SQLParameters);
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

        public void ExcuteBulkInsertCommand<B>(List<B> aEnitites, string con) where B : EntityBase, new()
        {
            foreach (var v in aEnitites)
            {
                ExcuteInsertCommand<B>(v, con);
            }
        }

        public void ExcuteUpdateCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {

            SqlConnection l_Connection = new SqlConnection(con);

            SqlCommand l_Command = new SqlCommand();

            l_Command.Connection = l_Connection;

            var l_QueryBuilder = new UpdateSQLBuilder<B>(aEntity);

            QueryDirector<B> l_Construct = new QueryDirector<B>(l_QueryBuilder);

            var l_Context = l_Construct.GetDataContext();

            l_Command.CommandText = l_Context.mSQL;

            foreach (var l_SQLParameters in l_Context.mSQLParameters)
            {
                l_Command.Parameters.Add(l_SQLParameters);
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

        public void ExcuteDeleteCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {
            SqlConnection Connection = new SqlConnection(con);

            SqlCommand Command = new SqlCommand();

            Command.Connection = Connection;

            var l_QueryBuilder = new DeleteBuilder<B>(aEntity);

            QueryDirector<B> l_Construct = new QueryDirector<B>(l_QueryBuilder);

            var l_Context = l_Construct.GetDataContext();

            Command.CommandText = l_Context.mSQL;

            foreach (var l_SQLParameters in l_Context.mSQLParameters)
            {
                Command.Parameters.Add(l_SQLParameters);
            }

            try
            {
                Connection.Open();

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
        }

        #endregion

    }
}