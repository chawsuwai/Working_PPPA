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
    public class ProbesQtyDAO : DAO<PQuantityEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<PQuantityEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<PQuantityEntity> FindByCriteria()
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
                ExcuteDeleteCommand<PQuantityEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<PQuantityEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override PQuantityEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<PQuantityEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override PQuantityEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override PQuantityEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public PQuantityEntity FindQty()
        {
            try
            {
                var query = "SELECT * FROM " + Table<PQuantityEntity>();
                return ExcuteStoreQuery<PQuantityEntity>(query, null, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal PQuantityEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<PQuantityEntity>() + " WHERE " + With<RateEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<PQuantityEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}