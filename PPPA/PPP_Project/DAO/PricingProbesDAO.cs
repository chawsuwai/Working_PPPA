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
    public class PricingProbesDAO:DAO<PricingProbesEntity>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<PricingProbesEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<PricingProbesEntity> FindByCriteria()
        {
            try
            {
                var sql = " SELECT * FROM " + Table<PricingProbesEntity>() + " WHERE 1=1";
                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<PricingProbesEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<PricingProbesEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<PricingProbesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //FindPricingProbesJobImportList
        public List<PricingProbesEntity> FindPricingProbesJobImportList()
        {
            try
            {
                var sql = " SELECT PricingProbes.QAT,PricingProbes.Center,PricingProbes.TotalPricingProbes FROM " + Table<PricingProbesEntity>() + " WHERE 1=1";
                var param = new List<DbParameter>();

                if (!string.IsNullOrEmpty(Criteria.CenterName))
                {
                    sql += " AND " + With<PricingProbesEntity>(x => x.Center) + "= @CenterName";
                    param.Add(new SqlParameter { ParameterName = "@CenterName", Value = Criteria.CenterName });
                }

                if (!string.IsNullOrEmpty(Criteria.FromDate) && !string.IsNullOrEmpty(Criteria.ToDate))
                {
                    sql += " AND " + With<PricingProbesEntity>(x => x.CreatedDate) + " BETWEEN @FromDate AND @ToDate";
                    param.Add(new SqlParameter { ParameterName = "@FromDate", Value = Criteria.FromDate });
                    param.Add(new SqlParameter { ParameterName = "@ToDate", Value = Criteria.ToDate });
                }

                return ExcuteStoreQuery<PricingProbesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

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
                ExcuteDeleteCommand<PricingProbesEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<PricingProbesEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override PricingProbesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<PricingProbesEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override PricingProbesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override PricingProbesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<PricingProbesEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                var sql = "SELECT * FROM " + Table<PricingProbesEntity>() + " WHERE " + With<PricingProbesEntity>(x => x.ImportedDate) + "=@ImpDate" + " AND " + With<PricingProbesEntity>(x => x.Center) + "=@Center";

                return ExcuteStoreQuery<PricingProbesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForPricingProbes()
        {
            try
            {
                var sql = "Exec Export_WithoutDe_PricingProbes";
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

        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbes()
        {
            try
            {
                var sql = "Exec Export_WithDe_PricingProbes_DiffMonth";
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

                return ExcuteStoreQuery<ExportPricingProbes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSingle()
        {
            try
            {
                var sql = "Exec Export_WithDe_PricingProbes_DiffMonth_GSS";
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

                return ExcuteStoreQuery<ExportPricingProbes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSingleIGS()
        {
            try
            {
                var sql = "Exec Export_WithDe_PricingProbes_DiffMonth_IGS";
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

                return ExcuteStoreQuery<ExportPricingProbes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSpecial()
        {
            try
            {
                var sql = "Exec Export_WithDe_PricingProbes_DiffMonth_Special";
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
                    param.Add(new SqlParameter { ParameterName = "@Month", Value = Criteria.Month1});
                }

                sql += ", " + " @Month2 " + "= @AccMonth2";
                param.Add(new SqlParameter { ParameterName = "@AccMonth2", Value = Criteria.Month2 });

                sql += ", " + " @FromDate2 " + "= @FromDate2" + ", " + "@ToDate2" + "= @ToDate2";
                param.Add(new SqlParameter { ParameterName = "@FromDate2", Value = Criteria.FromDate2 });
                param.Add(new SqlParameter { ParameterName = "@ToDate2", Value = Criteria.ToDate2 });

                return ExcuteStoreQuery<ExportPricingProbes>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATPricingProbes(string center)
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "Replace_QAT_PricingProbes";

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