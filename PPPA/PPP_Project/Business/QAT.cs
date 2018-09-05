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

namespace PPP_Project.Business
{
    public class QAT : BusinessLogic<QATEntity, QATDAO>
    {
        public override QATEntity Entity
        {
            get;
            set;
        }

        public override List<QATEntity> EntityList
        {
            get;
            set;
        }

        public override QATDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new QATEntity();
            DAO = new QATDAO();
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
            try
            {
                Map_Object();
                DAO.Update();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public override QATEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override QATEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<QATEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override QATEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<QATEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<QATEntity> FindByImportedDate(string importDate, string center)
        {
            try
            {
                return DAO.FindByImportedDate(importDate,center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<QATEntity> AllQAT()
        {
            try
            {
                return DAO.AllQAT();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReplaceQAT(string center)
        {
            try
            {
                DAO.ReplaceQAT(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}