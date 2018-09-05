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
    public class SceneRecognition:BusinessLogic<SceneRecognitionEntity,SceneRecognitionDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override SceneRecognitionEntity Entity
        {
            get;
            set;
        }

        public override List<SceneRecognitionEntity> EntityList
        {
            get;
            set;
        }

        public override SceneRecognitionDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new SceneRecognitionEntity();
            DAO = new SceneRecognitionDAO();
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

        public List<SceneRecognitionEntity> Finds()
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

        public override SceneRecognitionEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override SceneRecognitionEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<SceneRecognitionEntity> FindByCriteria()
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

        public List<SceneRecognitionEntity> FindSceneRecognitionJobImport()
        {
            try
            {
                Map_Object();
                return DAO.FindSceneRecognitionJobImport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override SceneRecognitionEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<SceneRecognitionEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<SceneRecognitionEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForSceneRecognition()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForSceneRecognition();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportSceneRecognition> FindByCriteriaDenominatorForSceneRecognition()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForSceneRecognition();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportSceneRecognition> FindByCriteriaDenominatorForSceneRecognitionSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForSceneRecognitionSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportSceneRecognition> FindByCriteriaDenominatorForSceneRecognitionSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForSceneRecognitionSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportSceneRecognition> FindByCriteriaDenominatorForSceneRecognitionSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForSceneRecognitionSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATSceneRecognition(string center)
        {
            try
            {
                DAO.ReplaceQATSceneRecognition(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}