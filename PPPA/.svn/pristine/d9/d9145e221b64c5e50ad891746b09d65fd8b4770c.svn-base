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
    public class SmartStitchingDAO:DAO<SmartStitchingEntity>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<SmartStitchingEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public override List<SmartStitchingEntity> FindByCriteria()
        {
            try
            {
                var sql = " SELECT * FROM " + Table<SmartStitchingEntity>() + " WHERE 1=1";
                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<SmartStitchingEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<SmartStitchingEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<SmartStitchingEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // FindSmartStitchingJobImportList
        public List<SmartStitchingEntity> FindSmartStitchingJobImportList()
        {
            try
            {
                var sql = " SELECT SmartStitching.QAT,SmartStitching.Center,SmartStitching.TotalSmartStitching FROM " 
                            + Table<SmartStitchingEntity>() + " WHERE 1=1";

                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<SmartStitchingEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<SmartStitchingEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<SmartStitchingEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            try
            {
                ExcuteDeleteCommand<SmartStitchingEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<SmartStitchingEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public override SmartStitchingEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<SmartStitchingEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override SmartStitchingEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override SmartStitchingEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<SmartStitchingEntity> FindByImportedDate(string importDate)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });

                var sql = "SELECT * FROM " + Table<SmartStitchingEntity>() + " WHERE " + With<SmartStitchingEntity>(x => x.ImportedDate) + "=@ImpDate";

                return ExcuteStoreQuery<SmartStitchingEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReplaceQATSmartStitching()
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "Exec Replace_QAT_SmartStitching";

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