﻿using System;
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
    public class ScenesDAO:DAO<ScenesEntity>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<ScenesEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public override List<ScenesEntity> FindByCriteria()
        {
            try
            {
                var sql = " SELECT * FROM " + Table<ScenesEntity>() + " WHERE 1=1";
                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<ScenesEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<ScenesEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<ScenesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // FindScenesJobImportList
        public List<ScenesEntity> FindScenesJobImportList()
        {
            try
            {
                var sql = " SELECT Scenes.QAT,Scenes.Center,Scenes.TotalScenes FROM " + Table<ScenesEntity>() + " WHERE 1=1";
                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<ScenesEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<ScenesEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<ScenesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

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
                ExcuteDeleteCommand<ScenesEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<ScenesEntity>(Entity,ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public override ScenesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ScenesEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override ScenesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ScenesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<ScenesEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                var sql = "SELECT * FROM " + Table<ScenesEntity>() + " WHERE " + With<ScenesEntity>(x => x.ImportedDate) + "=@ImpDate" + " AND " + With<ScenesEntity>(x => x.Center) + "=@Center"; 

                return ExcuteStoreQuery<ScenesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForScenes()
        {
            try
            {
                var sql = "Exec Export_WithoutDe_Scenes";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @CenterName";
                param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });

                //if (!string.IsNullOrEmpty(Criteria.CenterName))
                //{
                //    sql += " @Center " + "= @CenterName";
                //    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                //}

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<ExportViewWithoutDe>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportScenes> FindByCriteriaDenominatorForScenes()
        {
            try
            {
                var sql = "Exec Export_WithDe_Scenes_DiffMonth";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @CenterName";
                param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });

                //if (!string.IsNullOrEmpty(Criteria.CenterName))
                //{
                //    sql += " @Center " + "= @CenterName";
                //    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                //}

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }


                if (!string.IsNullOrEmpty(Criteria.ToDate))
                {
                    string dmonth = Criteria.ToDate.Substring(0, 6);
                    sql += ", " + "@Month" + "= @Month";
                    param.Add(new SqlParameter { ParameterName = "@Month", Value = dmonth });
                }

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Criteria.Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = Criteria.FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = Criteria.ToDate2 });   

                return ExcuteStoreQuery<ExportScenes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportScenes> FindByCriteriaDenominatorForScenesSingleIGS()
        {
            try
            {
                var sql = "Exec Export_WithDe_Scenes_DiffMonth_IGS";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @CenterName";
                param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });

                //if (!string.IsNullOrEmpty(Criteria.CenterName))
                //{
                //    sql += " @Center " + "= @CenterName";
                //    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                //}

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }


                if (!string.IsNullOrEmpty(Criteria.ToDate))
                {
                    string dmonth = Criteria.ToDate.Substring(0, 6);
                    sql += ", " + "@Month" + "= @Month";
                    param.Add(new SqlParameter { ParameterName = "@Month", Value = dmonth });
                }

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Criteria.Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = Criteria.FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = Criteria.ToDate2 });

                return ExcuteStoreQuery<ExportScenes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportScenes> FindByCriteriaDenominatorForScenesSingle()
        {
            try
            {
                var sql = "Exec Export_WithDe_Scenes_DiffMonth_GSS";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @CenterName";
                param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });

                //if (!string.IsNullOrEmpty(Criteria.CenterName))
                //{
                //    sql += " @Center " + "= @CenterName";
                //    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                //}

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }


                if (!string.IsNullOrEmpty(Criteria.ToDate))
                {
                    string dmonth = Criteria.ToDate.Substring(0, 6);
                    sql += ", " + "@Month" + "= @Month";
                    param.Add(new SqlParameter { ParameterName = "@Month", Value = Criteria.Month1 });
                }

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Criteria.Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = Criteria.FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = Criteria.ToDate2 });

                return ExcuteStoreQuery<ExportScenes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportScenes> FindByCriteriaDenominatorForScenesSpecial()
        {
            try
            {
                var sql = "Exec Export_WithDe_Scenes_DiffMonth_Special";
                var param = new List<DbParameter>();

                sql += " @Center " + "= @CenterName";
                param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });

                //if (!string.IsNullOrEmpty(Criteria.CenterName))
                //{
                //    sql += " @Center " + "= @CenterName";
                //    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                //}

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += ", " + " @FromDate " + "= @FromDate" + ", " + "@ToDate" + "= @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }


                if (!string.IsNullOrEmpty(Criteria.ToDate))
                {
                    string dmonth = Criteria.ToDate.Substring(0, 6);
                    sql += ", " + "@Month" + "= @Month";
                    param.Add(new SqlParameter { ParameterName = "@Month", Value = Criteria.Month1 });
                }

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Criteria.Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = Criteria.FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = Criteria.ToDate2 });

                return ExcuteStoreQuery<ExportScenes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATScenes(string center)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "Replace_QAT_Scenes";

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