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
    public class AccPerRateDAO : DAO<AccPerRateEntity>
    {
        public override void Save()
        {
            ExcuteInsertCommand<AccPerRateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
        }

        public override List<AccPerRateEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            ExcuteDeleteCommand<AccPerRateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
        }

        public override void Update()
        {
            ExcuteUpdateCommand<AccPerRateEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
        }

        public override AccPerRateEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<AccPerRateEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override AccPerRateEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override AccPerRateEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public AccPerRateEntity FindRate()
        {
            try
            {
                var query = "SELECT * FROM " + Table<AccPerRateEntity>();
                return ExcuteStoreQuery<AccPerRateEntity>(query, null, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal AccPerRateEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<AccPerRateEntity>() + " WHERE " + With<AccPerRateEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<AccPerRateEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}