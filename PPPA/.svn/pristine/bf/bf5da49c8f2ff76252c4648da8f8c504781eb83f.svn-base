using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.Entity;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using PPP_Project.Common.Enum;
using PPP_Project.Common.Extension;

namespace PPP_Project.DAO
{
    public class QATDAO : DAO<QATEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<QATEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<QATEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            try
            {
                ExcuteDeleteCommand<QATEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Update()
        {
            try
            {
                ExcuteUpdateCommand<QATEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override QATEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<QATEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override QATEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override QATEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<QATEntity> FindByImportedDate(string importDate, string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                var sql = "SELECT * FROM " + Table<QATEntity>() + " WHERE " + With<QATEntity>(x => x.Month) + "=@ImpDate" + " AND " + With<QATEntity>(x => x.Center) + "=@Center";

                return ExcuteStoreQuery<QATEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<QATEntity> AllQAT()
        {
            try
            {
                var param = new List<DbParameter>();

                var sql = "SELECT * FROM " + Table<QATEntity>();

                return ExcuteStoreQuery<QATEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReplaceQAT(string center)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "Replace_QAT";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Center", center));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}