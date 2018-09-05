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
    public class TicTac : BusinessLogic<TicTacEntity, TicTacDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override TicTacEntity Entity
        {
            get;
            set;
        }

        public override List<TicTacEntity> EntityList
        {
            get;
            set;
        }

        public override TicTacDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new TicTacEntity();
            DAO = new TicTacDAO();
        }

        public override void Map_Object()
        {
            try
            {
                DAO.Entity = this.Entity;
                DAO.EntityList = this.EntityList;
                DAO.Criteria = this.Criteria;
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

        public override TicTacEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override TicTacEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<TicTacEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override TicTacEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<TicTacEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<TicTacEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                return DAO.FindByImportedDateAndCenter(importDate, center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportTicTacs> FindByCriteriaDenominatorForTicTacs()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForTicTacs();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}