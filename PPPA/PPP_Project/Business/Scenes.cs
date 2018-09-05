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
    public class Scenes:BusinessLogic<ScenesEntity,ScenesDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override ScenesEntity Entity
        {
            get;
            set;
        }

        public override List<ScenesEntity> EntityList
        {
            get;
            set;
        }

        public override ScenesDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new ScenesEntity();
            DAO = new ScenesDAO();
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

        public List<ScenesEntity> Finds()
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

        public override ScenesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ScenesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<ScenesEntity> FindByCriteria()
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

        // FindScenesJobImportList
        public List<ScenesEntity> FindScenesJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindScenesJobImportList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override ScenesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ScenesEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<ScenesEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                return DAO.FindByImportedDateAndCenter(importDate,center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForScenes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForScenes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportScenes> FindByCriteriaDenominatorForScenes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForScenes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportScenes> FindByCriteriaDenominatorForScenesSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForScenesSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportScenes> FindByCriteriaDenominatorForScenesSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForScenesSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportScenes> FindByCriteriaDenominatorForScenesSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForScenesSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATScenes(string center)
        {
            try
            {
                DAO.ReplaceQATScenes(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}