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

namespace PPP_Project.Criteria
{
    public class SmartStitching:BusinessLogic<SmartStitchingEntity,SmartStitchingDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override SmartStitchingEntity Entity
        {
            get;
            set;
        }

        public override List<SmartStitchingEntity> EntityList
        {
            get;
            set;
        }

        public override SmartStitchingDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new SmartStitchingEntity();
            DAO = new SmartStitchingDAO();
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

        public List<SmartStitchingEntity> Finds()
        {
            try
            {
                return DAO.Finds();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public override SmartStitchingEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override SmartStitchingEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<SmartStitchingEntity> FindByCriteria()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteria();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SmartStitchingEntity> FindSmartStitchingJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindSmartStitchingJobImportList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override SmartStitchingEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<SmartStitchingEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<SmartStitchingEntity> FindByImportedDate(string importDate)
        {
            try
            {
                return DAO.FindByImportedDate(importDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReplaceQATSmartStitching()
        {
            try
            {
                DAO.ReplaceQATSmartStitching();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}