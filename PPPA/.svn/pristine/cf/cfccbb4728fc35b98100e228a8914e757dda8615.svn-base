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
    public class TicTacDAO : DAO<TicTacEntity>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<TicTacEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<TicTacEntity> FindByCriteria()
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
                ExcuteDeleteCommand<TicTacEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override TicTacEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<TicTacEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override TicTacEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override TicTacEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<TicTacEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@Center", Value = center });

                var sql = "SELECT * FROM " + Table<TicTacEntity>() + " WHERE " + With<TicTacEntity>(x => x.TicTacDate) + "=@ImpDate" + " AND " + With<TicTacEntity>(x => x.Center) + "=@Center";

                return ExcuteStoreQuery<TicTacEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportTicTacs> FindByCriteriaDenominatorForTicTacs()
        {
            try
            {
                var sql = "Exec Export_WithDe_TicTacs_DiffMonth";
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

                return ExcuteStoreQuery<ExportTicTacs>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}