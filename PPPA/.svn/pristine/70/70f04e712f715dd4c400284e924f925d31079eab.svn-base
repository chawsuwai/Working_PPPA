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
    public class DenoChangeDAO : DAO<DenoChangeEntity>
    {
        public override void Save()
        {
            try
            {
                ExcuteInsertCommand<DenoChangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<DenoChangeEntity> FindByCriteria()
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
                ExcuteDeleteCommand<DenoChangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
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
                ExcuteUpdateCommand<DenoChangeEntity>(Entity, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override DenoChangeEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<DenoChangeEntity> FindByModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public override DenoChangeEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override DenoChangeEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        internal DenoChangeEntity FindDataByID(string id)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<DenoChangeEntity>() + " WHERE " + With<DenoChangeEntity>(x => x.ID) + "=@ID";
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@ID", Value = id });
                return ExcuteStoreQuery<DenoChangeEntity>(sql, param, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<SheetEntity> FindAllSheet()
        {
            try
            {
                var sql = "SELECT * FROM Sheet";
                return ExcuteStoreQuery<SheetEntity>(sql, null, ConnectionDAO.Client.ToConnectionString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateDenominatorChangeForProject(string project, string month, decimal Multiply, string type,string dcdate,string id)
        {
            
                SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                //var sql = "UPDATE SET PROJECT='" + project + "',DCDate='" + dcdate + "',DCMultiply='" + Multiply + "',elligiblity='" + Label12.Text + "' WHERE ID = " + id + "";


                 string sql = " Update DenoChange set "+ type+ " =(SELECT ISNULL((SELECT "+ type +" * " +Multiply+ " FROM ProjectDenominators WHERE ProjectDenominators.PROJECT =" + project +" AND  ProjectDenominators.DenoMonth ="+ month +" ), 0)) ,PROJECT="+ project +" ,DCDate="+dcdate+" ,DCMultiply="+Multiply+" Where ID="+id;

                SqlCommand  cmd = new SqlCommand (sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
            }


               // var param = new List<DbParameter>();
               // param.Add(new SqlParameter { ParameterName = "@project", Value = project });
               // param.Add(new SqlParameter { ParameterName = "@month", Value = month });
               // //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });

               // var sql = "SELECT ISNULL( (SELECT " + type + "*" + Multiply + " FROM" + Table<DenoChangeEntity>() + " WHERE " + With<DenoChangeEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month" + "), 0)";
               // SqlCommand cmd = new SqlCommand("insert into Employeemaster values('" + EmployeeId + "','" + EmployeeName + "','" + EmployeeDepartment + "','" + EmployeeDesignation + "','" + DOB + "','" + DOJ + "')", conn);
               // //cmd.ExecuteNonQuery();
               // //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
               //ExcuteNonQuery(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string getCountForProject(string project, string dcDate)
        {
            try
            {
                var param = new List<DbParameter>();
                param.Add(new SqlParameter { ParameterName = "@project", Value = project });
                param.Add(new SqlParameter { ParameterName = "@dcDate", Value = dcDate });
                //  param.Add(new SqlParameter { ParameterName = "@type", Value = type });            

                var sql = "SELECT ISNULL( (SELECT Count(*) FROM" + Table<DenoChangeEntity>() + " WHERE " + With<DenoChangeEntity>(x => x.PROJECT) + "=@project" + " AND " + With<DenoChangeEntity>(x => x.DCDate) + "=@dcDate" + "), 0)";

                //var sql = "SELECT " + type+ "*"+ Multiply + " FROM " + Table<ProjectDenominatorsEntity>() + " WHERE " + With<ProjectDenominatorsEntity>(x => x.PROJECT) + "=@project" + " AND " + With<ProjectDenominatorsEntity>(x => x.DenoMonth) + "=@month";
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string getCountForProjectByDate(string dcDate)
        {
            try
            {
                var param = new List<DbParameter>();                
                param.Add(new SqlParameter { ParameterName = "@dcDate", Value = dcDate });              

                var sql = "SELECT ISNULL( (SELECT Count(*) FROM" + Table<DenoChangeEntity>() + " WHERE "+ With<DenoChangeEntity>(x => x.DCDate) + "=@dcDate" + "), 0)";

                
                return ExcuteScalar(sql, param, ConnectionDAO.Client.ToConnectionString()).ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteNullValue()
        {

            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(ConnectionDAO.Client.ToConnectionString());
                connection.Open();
                string sql = "delete from DenoChange where Probes is null and Pricingprobes is null and Votes is null and Masks is null and Repricing is null and SceneRecog is null and ProbesperScene is null and Expert is null and ExpertVoting is null";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DenoChangeEntity FindByProjectAndChangeDate(DenoChangeEntity entity)
        {
            try
            {
                var sql = "SELECT * FROM " + Table<DenoChangeEntity>() + " WHERE 1=1 ";
                sql += " AND PROJECT = '" + entity.PROJECT + "' AND DCDate = '" + entity.DCDate+"'";
                return ExcuteStoreQuery<DenoChangeEntity>(sql, null, ConnectionDAO.Client.ToConnectionString()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        

        }
    
}