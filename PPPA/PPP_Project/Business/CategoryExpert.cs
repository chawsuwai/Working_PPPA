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
    public class CategoryExpert:BusinessLogic<CategoryExpertEntity,CategoryExpertDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override CategoryExpertEntity Entity
        {
            get;
            set;
        }

        public override List<CategoryExpertEntity> EntityList
        {
            get;
            set;
        }

        public override CategoryExpertDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new CategoryExpertEntity();
            DAO = new CategoryExpertDAO();
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

        public List<CategoryExpertEntity> Finds()
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

        public override CategoryExpertEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override CategoryExpertEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertEntity> FindByCriteria()
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

        public List<CategoryExpertEntity> FindCategoryExpertJobImport()
        {
            try
            {
                Map_Object();
                return DAO.FindCategoryExpertJobImport();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public override CategoryExpertEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<CategoryExpertEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForCategoryExpert()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForCategoryExpert();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpert> FindByCriteriaDenominatorForCategoryExpert()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpert();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpert> FindByCriteriaDenominatorForCategoryExpertSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpert> FindByCriteriaDenominatorForCategoryExpertSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpert> FindByCriteriaDenominatorForCategoryExpertSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATCategoryExpert(string center)
        {
            try
            {
                DAO.ReplaceQATCategoryExpert(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}