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
    public class ProbesRateDAO : DAO<RateEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<RateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<RateEntity> FindByCriteria()
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
                ExcuteDeleteCommand<RateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<RateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override RateEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<RateEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override RateEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override RateEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public RateEntity FindRate()
        {
            try
            {
                var query = "SELECT * FROM " + Table<RateEntity>();
                return ExcuteStoreQuery<RateEntity>(query, null, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal RateEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<RateEntity>() + " WHERE " + With<RateEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<RateEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getRangeLabel(int id)
        {
            try
            {
                var sql = "SELECT Range FROM " + Table<ProbesRangeEntity>() + " WHERE " + With<ProbesRangeEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });


                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}