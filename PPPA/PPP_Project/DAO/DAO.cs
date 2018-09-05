using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Common.Feature;
using PPP_Project.Common.Builder;
using System.Data;
using System.Linq.Expressions;
using PPP_Project.Common.Expression;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Extension;
using PPP_Project.Common.Enum;

namespace PPP_Project.Base
{
    public abstract class DAO<T> : IDBReadable<T>, IDBWriteable where T : EntityBase, new()
    {
        DBReader<T> DBReader = new DBReader<T>(); // feature

        DBWriter DBWriter = new DBWriter();
        // feature
        public T Entity { get; set; }

        public List<T> EntityList { get; set; }

        public DAO()
            : base()
        {
            Entity = new T();
            EntityList = new List<T>();
        }


        public QueryContext<T> GetQueryContext(T item)
        {
            ISqlBuilder<T> builder = new InsertSqlBuilder<T>(item);
            QueryDirector<T> director = new QueryDirector<T>(builder);
            return director.GetDataContext();
        }


        public abstract void Save();

        //public abstract List<T> FindKeyValue(string aKeyColumnName, string aValueColumnName);


        public abstract List<T> FindByCriteria();

        public abstract void Saves();

        public abstract void Delete();

        public abstract void Update();

        public abstract T FindByBarCode(string barCode);

        public abstract List<T> FindByModelCode(string modelCode);

        public abstract T FindByID(int id);

        public abstract T FindByID(string id);


        public List<T> Finds()
        {
            var sql = "SELECT * FROM " + Table<T>();
            return ExcuteStoreQuery<T>(sql, null, ConnectionDAO.Client.ToConnectionString());
        }

        public List<B> ExcuteStoreQuery<B>(string aSQL, List<System.Data.Common.DbParameter> aPrams, string con, CommandType aCommendType = CommandType.Text) where B : new()
        {
            return DBReader.ExcuteStoreQuery<B>(aSQL, aPrams, con, aCommendType);
        }

        public List<B> ExcuteStoreQuery<B>(string aSQL, List<System.Data.Common.DbParameter> aPrams, string con) where B : new()
        {
            return ExcuteStoreQuery<B>(aSQL, aPrams, con, CommandType.Text);
        }

        public object ExcuteScalar(string aSQL, List<System.Data.Common.DbParameter> aPrams, string con)
        {
            return DBReader.ExcuteScalar(aSQL, aPrams, con);
        }

        public void ExcuteNonQuery(string aSQL, List<System.Data.Common.DbParameter> aParams, string con)
        {
            throw new NotImplementedException();
           
        }

        public void ExcuteInsertCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {
            DBWriter.ExcuteInsertCommand<B>(aEntity, con);
        }

        public void ExcuteBulkInsertCommand<B>(List<B> aEnitites, string con) where B : EntityBase, new()
        {
            //throw new NotImplementedException();
            DBWriter.ExcuteBulkInsertCommand<B>(aEnitites, con);
        }

        public void ExcuteUpdateCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {
            DBWriter.ExcuteUpdateCommand<B>(aEntity, con);
        }

        public void ExcuteDeleteCommand<B>(B aEntity, string con) where B : EntityBase, new()
        {
            DBWriter.ExcuteDeleteCommand<B>(aEntity, con);
        }

        public string With<E>(Expression<Func<E, object>> aExpression) where E : EntityBase, new()
        {
            string l_TableName = new ExpressionHelper<E>().GetClassAttribute<DbTableAttribute>(typeof(E)).Name;

            if (string.IsNullOrWhiteSpace(l_TableName) || string.IsNullOrEmpty(l_TableName))
            {

                l_TableName = Entity.TableName;
            }
            return " " + l_TableName + "." + new ExpressionHelper<E>().GetMemberAttribute<DbColumnAttribute>(aExpression).Name + " ";
        }

        public string Table<E>() where E : EntityBase, new()
        {
            string l_TableName = new ExpressionHelper<E>().GetClassAttribute<DbTableAttribute>(typeof(E)).Name;

            if (string.IsNullOrWhiteSpace(l_TableName) || string.IsNullOrEmpty(l_TableName))
            {
                l_TableName = Entity.TableName;
            }

            return " " + l_TableName + " ";
        }

    }
}