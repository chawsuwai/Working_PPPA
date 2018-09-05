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
    public class ProjectNamesDAO : DAO<ProjectNamesEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<ProjectNamesEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<ProjectNamesEntity> FindByCriteria()
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
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectNamesEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectNamesEntity> FindByImportedDate(string importDate)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });

                var sql = "SELECT * FROM " + Table<ProjectNamesEntity>() + " WHERE " + With<ProjectNamesEntity>(x => x.ImportMonth) + "=@ImpDate";

                return ExcuteStoreQuery<ProjectNamesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProjectNamesEntity> FindByImportedDateWithSheet(string importDate,string SheetName,string Status)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@ImpDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@SheetName", Value = SheetName });
                param.Add(new SqlParameter { ParameterName = "@Status", Value = Status });

                var sql = "SELECT * FROM " + Table<ProjectNamesEntity>() + " WHERE " + With<ProjectNamesEntity>(x => x.ImportMonth) + "=@ImpDate" + " AND " + With<ProjectNamesEntity>(x => x.Sheet) + "=@SheetName" + " AND " + With<ProjectNamesEntity>(x => x.Status) + "=@Status";

                return ExcuteStoreQuery<ProjectNamesEntity>(sql, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProjectNamesEntity> FindByProjectName(string importDate ,string SheetName)
        {
            try
            {
                var param = new List<DbParameter>();

                param.Add(new SqlParameter { ParameterName = "@importDate", Value = importDate });
                param.Add(new SqlParameter { ParameterName = "@SheetName", Value = SheetName });

                var sql1 = "Select * from ProjectNames where ImportMonth=" + @importDate + " and Sheet =" + "'" + @SheetName + "'" + " and status='WithoutDeno' and PROJECT not in (select PROJECT from ProjectNames where ImportMonth=" + @importDate + " and Sheet= " + "'" + @SheetName + "'" + " and status='WithDeno')";

                //var sql1 = "SELECT PROJECT FROM ProjectNames where ImportMonth=" + @importDate + " and project not in (SELECT project FROM ProjectDenominators where DenoMonth= " + @importDate + ")";               

                return ExcuteStoreQuery<ProjectNamesEntity>(sql1, param, ConnectionDAO.Client.ToConnectionString());

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}