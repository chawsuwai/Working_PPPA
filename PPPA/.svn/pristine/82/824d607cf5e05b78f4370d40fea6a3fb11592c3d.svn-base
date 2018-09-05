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
    public class CancelDAO : DAO<CancelEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<CancelEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<CancelEntity> FindByCriteria()
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
                ExcuteDeleteCommand<CancelEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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

        public override CancelEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<CancelEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override CancelEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override CancelEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<CancelEntity> FindByCancelMonthAndJob(string cancelMonth, string job,string center)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@cancelMonth", Value = cancelMonth });
                param.Add(new SqlParameter { ParameterName = "@center", Value = center });

                var sql = "SELECT * FROM Cancel where CancelMonth=" + @cancelMonth + " And " + job + ">0 And Center=" +" ' " +@center+" ' ";

                return ExcuteStoreQuery<CancelEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}