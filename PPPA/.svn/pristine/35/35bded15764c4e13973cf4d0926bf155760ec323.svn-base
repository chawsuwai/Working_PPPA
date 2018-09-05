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

namespace PPP_Project.DAO
{
    public class ProjectDenominatorsDAO : DAO<ProjectDenominatorsEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<ProjectDenominatorsEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<ProjectDenominatorsEntity> FindByCriteria()
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
                ExcuteDeleteCommand<ProjectDenominatorsEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<ProjectDenominatorsEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override ProjectDenominatorsEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectDenominatorsEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override ProjectDenominatorsEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ProjectDenominatorsEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectDenominatorsEntity> FindByImportedDate(string importDate)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });

                var sql = "SELECT * FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@ImpDate";

                return ExcuteStoreQuery<ProjectDenominatorsEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProjectDenominatorsEntity> FindPROJECT()
        {
            var sql = "SELECT  distinct PROJECT  FROM " + Table<ProjectDenominatorsEntity>() + "Order by PROJECT";
            return ExcuteStoreQuery<ProjectDenominatorsEntity>(sql, null, ConnectionDAO.Client.ToConnectionString());
        }

        public string getDenominatorForProject(string project, string month, decimal Multiply, string type)
        {
            try
            {
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@project", Value = project });
                param.Add(new SqlParameter { ParameterName = "@month", Value = month });
                //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });

                var sql = "SELECT ISNULL( (SELECT " + type + "*" + Multiply + " FROM" + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month" + "), 0)";

                //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal ProjectDenominatorsEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<ProjectDenominatorsEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProjectDenominatorsEntity FindDataByProjectAndMonth(string sProject, string sMonth)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@PROJECT AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@DenoMonth";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@PROJECT", Value = sProject.ToUpper() });
                param.Add(new SqlParameter { ParameterName = "@DenoMonth", Value = sMonth });
                return ExcuteStoreQuery<ProjectDenominatorsEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}