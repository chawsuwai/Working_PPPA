using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.Entity;
using PPP_Project.Common.Enum;
using PPP_Project.Common.Extension;
using System.Data.Common;
using System.Data.SqlClient;

namespace PPP_Project.DAO
{
    public class UserDAO:DAO<UserEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<UserEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<UserEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            try
            {
                ExcuteUpdateCommand<UserEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override UserEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<UserEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override UserEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override UserEntity FindByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<UserEntity>() + " WHERE " + With<UserEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<UserEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserEntity FindByIDandPasswordandBranchCode(string id, string pw, string Bcode)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });

                param.Add(new SqlParameter { ParameterName = "@Password", Value = pw });

                param.Add(new SqlParameter { ParameterName = "@BranchCode", Value = Bcode });

                var sql = "SELECT * FROM " + Table<UserEntity>() + " WHERE " + With<UserEntity>(x => x.ID) + "=@ID AND " + With<UserEntity>(x => x.Password) + "=@Password AND" + With<UserEntity>(x => x.BranchCode) + "=@BranchCode";

                return ExcuteStoreQuery<UserEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}