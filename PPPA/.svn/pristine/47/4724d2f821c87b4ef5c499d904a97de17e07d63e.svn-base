using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.Entity;
using PPP_Project.DAO;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Extension;
using PPP_Project.Common.Enum;
using PPP_Project.Criteria;
namespace PPP_Project.Business
{
    public class Cancel : BusinessLogic<CancelEntity, CancelDAO>
    {
        public override CancelEntity Entity
        {
            get;
            set;
        }

        public override List<CancelEntity> EntityList
        {
            get;
            set;
        }

        public override CancelDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new CancelEntity();
            DAO = new CancelDAO();
        }

        public override void Map_Object()
        {
            try
            {
                DAO.Entity = this.Entity;
                DAO.EntityList = this.EntityList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Save()
        {
            try
            {
                Map_Object();
                DAO.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            try
            {
                Map_Object();
                DAO.Delete();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override CancelEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override CancelEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<CancelEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override CancelEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<CancelEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<CancelEntity> FindByCancelMonthAndJob(string cancelMonth, string job, string center)
        {
            try
            {
                return DAO.FindByCancelMonthAndJob(cancelMonth, job,center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}