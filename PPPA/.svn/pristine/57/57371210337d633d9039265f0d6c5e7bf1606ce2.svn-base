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
    public class AccuracyPercentageDAO : DAO<AccuracyEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<AccuracyEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<AccuracyEntity> FindByCriteria()
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
                ExcuteDeleteCommand<AccuracyEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<AccuracyEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override AccuracyEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<AccuracyEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override AccuracyEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override AccuracyEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<AccuracyEntity> FindByAccPerDate(string accDate, string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@AccDate", Value = accDate });
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                var sql = "SELECT * FROM " + Table<AccuracyEntity>() + " WHERE " + With<AccuracyEntity>(x => x.AccMonth) + "=@AccDate" + " AND " + With<AccuracyEntity>(x => x.Center) + "=@Center";

                return ExcuteStoreQuery<AccuracyEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthFor3PA(string center, string Month, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {

                var sql = "Exec master_pro";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });
              

                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql +=  ", " + " @Month " + "= @AccMonth";             
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });


                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });



                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ExportAccuracy> FindByMonthFor3PAGSS(string center, string Month, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {

                var sql = "Exec master_pro_GSS";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });


                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @Month " + "= @AccMonth";
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });


                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });



                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ExportAccuracy> FindByMonthForAbove96P(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {
     
            try
            {
             //  @Center nvarchar(30),@TotalProbes int,@Percent decimal(18,2),@Month nvarchar(30),@FromDate VARCHAR(8), @ToDate VARCHAR(8),@Month2 nvarchar(30),@FromDate2 VARCHAR(8), @ToDate2 VARCHAR(8)
                var sql = "Exec master_pro_cancel";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @TotalProbes " + "= @TotalProbes" + ", " + "@Percent" + "= @Percent" + ", " + " @Month " + "= @AccMonth";
                param.Add(new SqlParameter { ParameterName = "@TotalProbes", Value = Total});
                param.Add(new SqlParameter { ParameterName = "@Percent", Value = percent });
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });


                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });


                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });             


                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<ExportAccuracy> FindByMonthForAboveGSS(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {
                //  @Center nvarchar(30),@TotalProbes int,@Percent decimal(18,2),@Month nvarchar(30),@FromDate VARCHAR(8), @ToDate VARCHAR(8),@Month2 nvarchar(30),@FromDate2 VARCHAR(8), @ToDate2 VARCHAR(8)
                var sql = "Exec master_pro_cancel_GSS";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @TotalProbes " + "= @TotalProbes" + ", " + "@Percent" + "= @Percent" + ", " + " @Month " + "= @AccMonth";
                param.Add(new SqlParameter { ParameterName = "@TotalProbes", Value = Total });
                param.Add(new SqlParameter { ParameterName = "@Percent", Value = percent });
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });


                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });


                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });


                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthForUnder96P(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {
            try
            {
                var sql = "Exec master_pro_Under_96P";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @TotalProbes " + "= @TotalProbes" + ", " + "@Percent" + "= @Percent" + ", " + " @Month " + "= @AccMonth";
                param.Add(new SqlParameter { ParameterName = "@TotalProbes", Value = Total});
                param.Add(new SqlParameter { ParameterName = "@Percent", Value = percent });
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });

                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ExportAccuracy> FindByMonthForUnderGSS(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {
            try
            {
                var sql = "Exec master_pro_Under_96P_GSS";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @Center";
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                //sql += " @Month " + "= @AccMonth";  
                //param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @TotalProbes " + "= @TotalProbes" + ", " + "@Percent" + "= @Percent" + ", " + " @Month " + "= @AccMonth";
                param.Add(new SqlParameter { ParameterName = "@TotalProbes", Value = Total });
                param.Add(new SqlParameter { ParameterName = "@Percent", Value = percent });
                param.Add(new SqlParameter { ParameterName = "@AccMonth", Value = Month });

                sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                param.Add(new SqlParameter { ParameterName = "@ToDate", Value = ToDate });

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = ToDate2 });

                return ExcuteStoreQuery<ExportAccuracy>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AccuracyEntity> FindByQATWithAccMonth(string QAT,string accDate)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@AccDate", Value = accDate });
                param.Add(new SqlParameter { ParameterName = "@QAT", Value = QAT });

                var sql = "SELECT * FROM " + Table<AccuracyEntity>() + " WHERE " + With<AccuracyEntity>(x => x.QAT) + "=@QAT" + " AND " + With<AccuracyEntity>(x => x.AccMonth) + "=@AccDate"; 

                return ExcuteStoreQuery<AccuracyEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal AccuracyEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<AccuracyEntity>() + " WHERE " + With<AccuracyEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<AccuracyEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<AccuracyEntity> FindQAT()
        {
            var sql = "SELECT  distinct QAT,center  FROM " + Table<AccuracyEntity>() + "Order by QAT";
            return ExcuteStoreQuery<AccuracyEntity>(sql, null, ConnectionDAO.Client.ToConnectionString());
        }


        public void ReplaceQATAccuracy(string center)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "Replace_QAT_Accuracy";

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

        public string FindMonthAndYear(string FromDate)
        {
            try
            {
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });            

                var sql = "SELECT dateadd(m, 1, dbo.ChangeDT(" + @FromDate + "))";

                //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string FindPreviousMonth(string FromDate)
        {
            try
            {
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });            

                var sql = "SELECT dateadd(m, -1, dbo.ChangeDT(" + @FromDate + "))";

                //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FindLastDayOfMonth(string FromDate)
        {
            try
            {
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@FromDate", Value = FromDate });
                //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });            

                var sql = "SELECT REPLACE(EOMONTH(dbo.ChangeDT(" + @FromDate + ")),'-','')";

                //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        
    }
}