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
using PPP_Project.Criteria;

namespace PPP_Project.DAO
{
    public class ProbesRangeDAO : DAO<ProbesRangeEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<ProbesRangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<ProbesRangeEntity> FindByCriteria()
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
                ExcuteDeleteCommand<ProbesRangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<ProbesRangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override ProbesRangeEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProbesRangeEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override ProbesRangeEntity FindByID(int id)
        {
            var param = new List<DbParameter>();

            param.Add(new SqlParameter { ParameterName = "@ID", Value = id });

            var sql = "SELECT * FROM " + Table<ProbesRangeEntity>() + " WHERE " + With<ProbesRangeEntity>(x => x.ID) + "=@ID";

            return ExcuteStoreQuery<ProbesRangeEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
        }

        public override ProbesRangeEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<ProbesRangeEntity> FindRangeInfo()
        {

            var sql = "Select * From Range ORDER BY ID ASC";

            return ExcuteStoreQuery<ProbesRangeEntity>(sql, null, ConnectionDAO.Client.ToConnectionString());
        }

        public void UpdateRangeInfo(ProbesRangeEntity v)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "";
                if (v.ID != 3)
                {
                    sql = "UPDATE Range SET FromRange=" + v.FromRange + ",ToRange=" + v.ToRange + ",Range='" + v.FromRange + "-" + v.ToRange + "' WHERE id = " + v.ID + "";
                }
                else
                {
                    sql = "UPDATE Range SET FromRange=" + v.FromRange + ",ToRange=" + v.ToRange + ",Range='Above " + v.FromRange + "' WHERE id = " + v.ID + "";
                }

                SqlCommand cmd = new SqlCommand(sql, connection);
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